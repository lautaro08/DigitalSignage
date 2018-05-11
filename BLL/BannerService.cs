using System;
using System.Collections.Generic;
using DTO;
using DAL.EntityFramework;
using Domain;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace BLL
{
    public class BannerService : IBannerService
    {

        /// <summary>
        /// Logger
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private UnitOfWork iUnitOfWork;

        //lista de subscriptos para obtener el texto del banner actual
        private List<IObserver<string>> observers;

        //lista de banners activos en los proximos <UPDATE_TIME_IN_MINUTES> minutos
        private List<Banner> iNextBanners;

        //lista de banners activos en este momento
        private List<Banner> iCurrentBanners;

        //intervalo de tiempo en minutos en los que se vuelve a actualizar la lista actual de banners
        private const int UPDATE_TIME_IN_MINUTES = 10;


        //intervalo de tiempo en segundos en los que se actualizan las listas de banners
        private const int REFRESH_TIME_IN_SECONDS = 10;

        private string iCurrentText = "No hay ninguna campaña activa en este momento";

        //con este token se pueden cancelar los task asyncronos
        private CancellationToken cancellationToken;
        private CancellationTokenSource tokenSource;

        /// <summary>
        /// Constructor para usar contexto por defecto
        /// </summary>
        public BannerService()
        {
            this.iUnitOfWork = new UnitOfWork(new DigitalSignageDbContext());

            observers = new List<IObserver<string>>();
            iCurrentBanners = new List<Banner>();

            tokenSource = new CancellationTokenSource();
            cancellationToken = tokenSource.Token;

            log.Info("Iniciando tareas asincronas...");
            GetNextActiveBannersLoop();
            UpdateBannerListsLoop();
        }

        /// <summary>
        /// Crea un banner
        /// </summary>
        /// <param name="pBannerDTO">banner que se quiere crear</param>
        public void Create(BannerDTO pBannerDTO)
        {
            ///Mapea el DTO a un objecto Campaign
            var banner = new Banner();
            AutoMapper.Mapper.Map(pBannerDTO, banner);

            try
            {
                log.Info("Guardando banner");
                this.iUnitOfWork.BannerRepository.Add(banner);
                this.iUnitOfWork.Complete();
                log.Info("Banner creado con exito");

            }
            catch (ArgumentException e)
            {
                log.Error("Error al crear banner: " + e.Message);
                throw new ArgumentException();

            }
        }

        /// <summary>
        /// Obtiene un banner por su id
        /// </summary>
        /// <param name="pId">id del banner que se quiere obtener</param>
        /// <returns></returns>
        public BannerDTO Get(int pId)
        {
            try
            {

                log.Info("Obteniendo banner");
                var banner = iUnitOfWork.BannerRepository.Get(pId);
                log.Info("Banner obtenido con exito");

                var bannerDTO = new BannerDTO();
                AutoMapper.Mapper.Map(banner, bannerDTO);
                return bannerDTO;

            }
            catch (Exception e)
            {

                log.Error("Error al obtener campaña: " + e.Message);
                throw new Exception();

            }
        }

        /// <summary>
        /// Obtiene todos los banners
        /// </summary>
        public IEnumerable<BannerDTO> GetAll()
        {
            try
            {

                log.Info("Obteniendo todos los banners");
                IEnumerable<Banner> banners = iUnitOfWork.BannerRepository.GetAll();
                log.Info("Banners obtenidos con exito");

                var bannersDTO = AutoMapper.Mapper.Map<IEnumerable<Banner>, IEnumerable<BannerDTO>>(banners);

                return bannersDTO;

            }
            catch (Exception e)
            {

                log.Error("Error al obtener banners: " + e.Message);
                throw new Exception();

            }
        }

        /// <summary>
        /// Obtiene todaos los banners activos en un dia determinado
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public IEnumerable<BannerDTO> GetBannersActiveInDate(DateTime pDate)
        {
            try
            {

                log.Info("Obteniendo todos los banners activos en la fecha " + pDate.ToString());
                IEnumerable<Banner> banners = iUnitOfWork.BannerRepository.GetBannersActiveInDate(pDate);
                log.Info("Banners obtenidos con exito");

                var bannersDTO = AutoMapper.Mapper.Map<IEnumerable<Banner>, IEnumerable<BannerDTO>>(banners);

                return bannersDTO;

            }
            catch (Exception e)
            {

                log.Error("Error al obtener banners: " + e.Message);
                throw new Exception();

            }
        }

        /// <summary>
        /// Obtiene todos los banners cuyo nombre coincida por aproximacion al dado en el parametro
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public IEnumerable<BannerDTO> GetBannersByName(string pName)
        {
            try
            {

                log.Info("Obteniendo todos los banners que coincidan con el nombre " + pName);
                IEnumerable<Banner> banners = iUnitOfWork.BannerRepository.GetBannersByName(pName);
                log.Info("Banners obtenidos con exito");

                var bannersDTO = AutoMapper.Mapper.Map<IEnumerable<Banner>, IEnumerable<BannerDTO>>(banners);

                return bannersDTO;

            }
            catch (Exception e)
            {

                log.Error("Error al obtener banners: " + e.Message);
                throw new Exception();

            }
        }

        /// <summary>
        /// Eliminar un banner
        /// </summary>
        /// <param name="pBannerDTO">banner que se desea eliminar</param>
        public void Remove(BannerDTO pBannerDTO)
        {
            try
            {
                log.Info("Eliminando banner");
                Banner banner = iUnitOfWork.BannerRepository.Get(pBannerDTO.Id);
                iUnitOfWork.BannerRepository.Remove(banner);
                iUnitOfWork.Complete();
                log.Info("Banner eliminado con exito");

            }
            catch (ArgumentNullException e)
            {

                log.Error("Error al eliminar banner: " + e.Message);
                throw new ArgumentException();

            }
        }

        /// <summary>
        /// Actualiza un banner
        /// </summary>
        /// <param name="pBannerDTO">banner que se desea actualizar</param>
        public void Update(BannerDTO pBannerDTO)
        {
            ///campaña actualizada
            var updatedBanner = new Banner();
            AutoMapper.Mapper.Map(pBannerDTO, updatedBanner);

            try
            {
                //campaña anterior
                log.Info("Actualizando banner");
                var oldBanner = iUnitOfWork.BannerRepository.Get(updatedBanner.Id);

                //actualiza los datos
                oldBanner.Description = updatedBanner.Description;
                oldBanner.InitDate = updatedBanner.InitDate;
                oldBanner.EndDate = updatedBanner.EndDate;
                oldBanner.InitTime = updatedBanner.InitTime;
                oldBanner.EndTime = updatedBanner.EndTime;
                oldBanner.Name = updatedBanner.Name;

                if (updatedBanner.Source.Id > 0)
                {

                    oldBanner.SourceId = updatedBanner.Source.Id;

                }
                else
                {

                    oldBanner.Source = updatedBanner.Source;

                }

                //Guardando los cambios
                iUnitOfWork.Complete();

            }
            catch (Exception e)
            {

                log.Error("Error al actualizar banner: " + e.Message);
                throw new Exception();

            }
        }
        
        /// <summary>
        /// subscripcion para recibir el texto del banner actual
        /// </summary>
        /// <param name="observer"></param>
        /// <returns></returns>
        public IDisposable Subscribe(IObserver<string> observer)
        {
            // verifica que el observador no exista en la lista
            if (!observers.Contains(observer))
            {
                log.Info("Se ha añadido un subscriptor al banner service");
                observers.Add(observer);
                // Envia al nuevo s observador el texto actual.
                observer.OnNext(iCurrentText);
            }
            return new Unsubscriber<string>(observers, observer);
        }

        /// <summary>
        /// obtiene los banners que estaran activos en el siguiente lapso de tiempo
        /// </summary>
        private void GetNextActiveBanners()
        {
            //obtiene los banner que se encontraran activos en algun momento de los siguientes <UPDATE_TIME_IN_MINUTES> minutos
            var now = DateTime.Now;
            var actualTimespan = new TimeSpan(now.Hour, now.Minute, 0);
            iCurrentBanners.Clear();
            //obtiene los banner de la base de datos
            log.Info("Obteniendo banners activos");
            iNextBanners = iUnitOfWork.BannerRepository.GetActiveBannersInRange(now, actualTimespan, actualTimespan.Add(TimeSpan.FromMinutes(UPDATE_TIME_IN_MINUTES))).ToList();
            //actualiza los feeds rss de los banners
            UpdateRssSources();
        }

        /// <summary>
        /// verifica el estado de los banners para quitarlos de los actuales o agregarlos
        /// </summary>
        private void UpdateBannerLists()
        {
            bool somethingChange = false;
            //verifica que los banners que se estan mostrando no se hayan vencido
            iCurrentBanners.RemoveAll(b =>
                {
                    if (!b.IsActiveNow())
                    {
                        somethingChange = true;
                        return true;
                    }

                    return false;
                }
            );

            //verifica que no haya nuevos banners para agregar
            foreach (Banner banner in iNextBanners)
            {

                if (banner.IsActiveNow())
                {
                    somethingChange = true;
                    iCurrentBanners.Add(banner);
                }

            }
            //elimina los elementos de la lista de next banners
            iNextBanners.RemoveAll(b => b.IsActiveNow());

            if (somethingChange)
            {

                UpdateCurrentText();

            }

        }

        /// <summary>
        /// realiza el loop continuo para traer los siguientes banners
        /// </summary>
        private void GetNextActiveBannersLoop()
        {

            var interval = TimeSpan.FromMinutes(UPDATE_TIME_IN_MINUTES);

            // TODO: Add a CancellationTokenSource and supply the token here instead of None.
            RunPeriodicAsync(GetNextActiveBanners, interval, cancellationToken);

        }

        /// <summary>
        /// realiza el loop continuo para actualizar las listas 
        /// </summary>
        private void UpdateBannerListsLoop()
        {

            var interval = TimeSpan.FromSeconds(REFRESH_TIME_IN_SECONDS);

            // TODO: Add a CancellationTokenSource and supply the token here instead of None.
            RunPeriodicAsync(UpdateBannerLists, interval, cancellationToken);

        }

        // The `onTick` method will be called periodically unless cancelled.
        private static async Task RunPeriodicAsync(Action onTick, TimeSpan interval, CancellationToken token)
        {
            // Repeat this loop until cancelled.
            while (!token.IsCancellationRequested)
            {
                // Call our onTick function.
                onTick?.Invoke();

                // Wait to repeat again.
                if (interval > TimeSpan.Zero)
                    await Task.Delay(interval, token);
            }
        }

        /// <summary>
        /// Actualiza los feed Rss de los banners siguientes
        /// </summary>
        private void UpdateRssSources()
        {

            foreach (Banner banner in iNextBanners)
            {

                if(banner.Source is RssSource)
                {
                    var source = (RssSource)banner.Source;
                    Task.Run(() => {

                        try
                        {
                            IRssReader mRssReader = new RawXmlRssReader();
                            Uri uri;
                            Uri.TryCreate(source.Url, UriKind.Absolute, out uri);
                            var newRssItems = mRssReader.Read(uri).ToList();
                            if (newRssItems != null && newRssItems.Count > 0)
                            {
                                source.RssItems = AutoMapper.Mapper.Map<IList<RssItemDTO>, IList<RssItem>>(newRssItems);
                            }
                        }
                        catch (Exception)
                        {
                            log.DebugFormat("Error al actualizar los feeds del banner {0}", banner.Id);
                            return;
                        }
                        

                    });

                }

            }

        }

        /// <summary>
        /// actualiza el texto actual y notifica a los observadores
        /// </summary>
        public void UpdateCurrentText()
        {
            log.Info("Actualizando el texto del banner...");
            string updatedText = "";
            foreach (Banner banner in iCurrentBanners)
            {

                updatedText += banner.GetText() + " /// ";

            }
            iCurrentText = updatedText;
            foreach (var observer in observers)
            {

                observer.OnNext(iCurrentText);

            }
                  

        }

        /// <summary>
        /// cancela los procesos de actualizacion actuales y los vuelve a comenzar
        /// </summary>
        public void RefreshBanners()
        {
            log.Info("Actualizando todo el servicio de banner...");

            tokenSource.Cancel();
            tokenSource.Dispose();

            tokenSource = new CancellationTokenSource();
            cancellationToken = tokenSource.Token;

            GetNextActiveBannersLoop();
            UpdateBannerListsLoop();

        }

    }

    //clase que provee la funcionalidad a los observadores de desubscribirse
    public class Unsubscriber<T> : IDisposable
    {
        private List<IObserver<T>> _observers;
        private IObserver<T> _observer;

        public Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
