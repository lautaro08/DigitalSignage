using DTO;
using Domain;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace BLL
{
    public class CampaignService : ICampaignService
    {
        /// <summary>
        /// Logger
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private UnitOfWork iUnitOfWork;

        //lista de subscriptos para obtener la lista de imagenes actual
        private List<IObserver<byte[]>> observers;

        //lista de campañas en los proximos <UPDATE_TIME_IN_MINUTES> minutos
        private List<Campaign> iNextCampaigns;

        //lista de campañas activos en este momento
        private List<Campaign> iCurrentCampaigns;

        //lista de campañas activos en este momento que se estan mostrando en las pantallas
        //Sirve para evitar un cambio de golpe cuando se agrega o elimina una campaña de iCurrentCampaigns
        private List<Campaign> iShowingCampaigns;

        //lista de imagenes (concatenacion de imagenes de campañas actuales)
        private List<Image> iCurrentImages;

        //indeice de la imagen actual
        private int iCurrentImageIndex = 0;

        private byte[] iDefaultImage = File.ReadAllBytes("../../../assets/default.png");

        //intervalo de tiempo en minutos en los que se vuelve a actualizar la lista actual de campañas
        private const int UPDATE_TIME_IN_MINUTES = 10;


        //intervalo de tiempo en segundos en los que se actualizan las listas de campañas
        private const int REFRESH_TIME_IN_SECONDS = 10;

        //con este token se pueden cancelar los task asyncronos
        private CancellationToken cancellationToken;
        private CancellationTokenSource tokenSource;

        /// <summary>
        /// Constructor para usar contexto por defecto
        /// </summary>
        public CampaignService()
        {

            this.iUnitOfWork = new UnitOfWork(new DigitalSignageDbContext());

            observers = new List<IObserver<byte[]>>();
            iCurrentCampaigns = new List<Campaign>();
            iCurrentImages = new List<Image>();
            iCurrentImageIndex = 0;

            tokenSource = new CancellationTokenSource();
            cancellationToken = tokenSource.Token;

            GetNextActiveCampaignsLoop();
            UpdateCampaignListsLoop();
            UpdateCurrentImageIndex();

        }

        /// <summary>
        /// Crea una campaña
        /// </summary>
        /// <param name="pCampignDTO">camapaña que se quiere crear</param>
        public void Create(CampaignDTO pCampignDTO)
        {
            ///Mapea el DTO a un objecto Campaign
            var campaign = new Campaign();
            AutoMapper.Mapper.Map(pCampignDTO, campaign);

            ///Si hay una lista de Image entonces las mapea a sus DTO
            if (pCampignDTO.Images != null)
            {

                for (int i = 0; i < pCampignDTO.Images.Count; i++)
                {
                    AutoMapper.Mapper.Map(pCampignDTO.Images[i], campaign.Images[i]);
                }

            }

            try
            {
                log.Info("Guardando campaña");
                this.iUnitOfWork.CampaignRepository.Add(campaign);
                this.iUnitOfWork.Complete();
                log.Info("Campaña creada con exito");

            }
            catch (ArgumentException e)
            {
                log.Error("Error al crear campaña: " + e.Message);
                throw new ArgumentException();

            }

        }

        /// <summary>
        /// Eliminar una campaña
        /// </summary>
        /// <param name="pCampignDTO">camapaña que se desea eliminar</param>
        public void Remove(CampaignDTO pCampignDTO)
        {

            try
            {
                log.Info("Eliminando campaña");
                Campaign campaign = iUnitOfWork.CampaignRepository.Get(pCampignDTO.Id);
                iUnitOfWork.CampaignRepository.Remove(campaign);
                iUnitOfWork.Complete();
                log.Info("Campaña eliminada con exito");

            }
            catch (ArgumentNullException e)
            {

                log.Error("Error al eliminar campaña: " + e.Message);
                throw new ArgumentException();

            }

        }

        /// <summary>
        /// Actualiza una campaña
        /// </summary>
        /// <param name="pCampaignDTO">campaña que se desea actualizar</param>
        public void Update(CampaignDTO pCampaignDTO)
        {
            ///campaña actualizada
            var campaign = new Campaign();
            AutoMapper.Mapper.Map(pCampaignDTO, campaign);

            try
            {
                //campaña anterior
                log.Info("Actualizando campaña");
                iUnitOfWork.CampaignRepository.Update(campaign);

                //Guardando los cambios
                iUnitOfWork.Complete();

            }
            catch (Exception e)
            {

                log.Error("Error al actualizar camapaña: " + e.Message);
                throw new Exception();

            }

        }

        /// <summary>
        /// Obtiene una campaña por su id
        /// </summary>
        /// <param name="pId">id de la campaña que se quiere obtener</param>
        /// <returns></returns>
        public CampaignDTO Get(int pId)
        {

            try
            {

                log.Info("Obteniendo campaña");
                var campaign = iUnitOfWork.CampaignRepository.Get(pId);
                log.Info("Campaña obtenida con exito");

                var campaignDTO = new CampaignDTO();
                AutoMapper.Mapper.Map(campaign, campaignDTO);
                return campaignDTO;

            }
            catch (Exception e)
            {

                log.Error("Error al obtener campaña: " + e.Message);
                throw new Exception();

            }

        }


        /// <summary>
        /// Obtiene todas las campañas
        /// </summary>
        public IEnumerable<CampaignDTO> GetAll()
        {

            try
            {

                log.Info("Obteniendo todas las campañas");
                IEnumerable<Campaign> campaigns = iUnitOfWork.CampaignRepository.GetAll();
                log.Info("Campañas obtenidas con exito");

                var campaignsDTO = AutoMapper.Mapper.Map<IEnumerable<Campaign>, IEnumerable<CampaignDTO>>(campaigns);

                return campaignsDTO;

            }
            catch (Exception e)
            {

                log.Error("Error al obtener campaña: " + e.Message);
                throw new Exception();

            }

        }

        /// <summary>
        /// Obtiene todas las camapañas activas en un dia determinado
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public IEnumerable<CampaignDTO> GetCampaignsActiveInDate(DateTime pDate)
        {

            try
            {

                log.Info("Obteniendo todas las campañas activas en la fecha " + pDate.ToString());
                IEnumerable<Campaign> campaigns = iUnitOfWork.CampaignRepository.GetCampaignsActiveInDate(pDate);
                log.Info("Campañas obtenidas con exito");

                var campaignsDTO = AutoMapper.Mapper.Map<IEnumerable<Campaign>, IEnumerable<CampaignDTO>>(campaigns);

                return campaignsDTO;

            }
            catch (Exception e)
            {

                log.Error("Error al obtener campañas: " + e.Message);
                throw new Exception();

            }

        }

        /// <summary>
        /// Obtiene todas las camapañas cuyo nombre coincida por aproximacion al dado en el parametro
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public IEnumerable<CampaignDTO> GetCampaignsByName(string pName)
        {

            try
            {

                log.Info("Obteniendo todas las campañas que coincidan con el nombre " + pName);
                IEnumerable<Campaign> campaigns = iUnitOfWork.CampaignRepository.GetCampaignsByName(pName);
                log.Info("Campañas obtenidas con exito");

                var campaignsDTO = AutoMapper.Mapper.Map<IEnumerable<Campaign>, IEnumerable<CampaignDTO>>(campaigns);

                return campaignsDTO;

            }
            catch (Exception e)
            {

                log.Error("Error al obtener campañas: " + e.Message);
                throw new Exception();

            }

        }

        /// <summary>
        /// subscripcion para recibir el texto del banner actual
        /// </summary>
        /// <param name="observer"></param>
        /// <returns></returns>
        public IDisposable Subscribe(IObserver<byte[]> observer)
        {
            // verifica que el observador no exista en la lista
            if (!observers.Contains(observer))
            {
                observers.Add(observer);

                if (iCurrentImages.Count > 0)
                {

                    // Envia al nuevo s observador la imagen actual.
                    observer.OnNext(iCurrentImages[iCurrentImageIndex].Bytes);

                }
                else
                {

                    // Envia al nuevo s observador la imagen por defecto
                    observer.OnNext(iDefaultImage);

                }
                
            }
            return new Unsubscriber<byte[]>(observers, observer);
        }

        /// <summary>
        /// obtiene las campañas que estaran activas en el siguiente lapso de tiempo
        /// </summary>
        private void GetNextActiveCmapaigns()
        {
            //obtiene las campañas que se encontraran activas en algun momento de los siguientes <UPDATE_TIME_IN_MINUTES> minutos
            var now = DateTime.Now;
            var actualTimespan = new TimeSpan(now.Hour, now.Minute, 0);
            iCurrentCampaigns.Clear();
            //obtiene las campañas de la base de datos
            iNextCampaigns = iUnitOfWork.CampaignRepository.GetActiveCampaignsInRange(now, actualTimespan, actualTimespan.Add(TimeSpan.FromMinutes(UPDATE_TIME_IN_MINUTES))).ToList();

        }

        /// <summary>
        /// verifica el estado de las campañas para quitarlas de las actuales o agregarlas
        /// </summary>
        private void UpdateCampaignLists()
        {

            //verifica que las cmapañas que se estan mostrando no se hayan vencido
            iCurrentCampaigns.RemoveAll(c =>!c.IsActiveNow() );

            //verifica que no haya nuevas campañas para agregar
            foreach (Campaign campaign in iNextCampaigns)
            {

                if (campaign.IsActiveNow())
                {
                    iCurrentCampaigns.Add(campaign);
                }

            }
            //elimina los elementos de la lista de next campaigns
            iNextCampaigns.RemoveAll(c => c.IsActiveNow());

        }

        /// <summary>
        /// actualiza la lista actual de imagenes
        /// </summary>
        public void UpdateCurrentImages()
        {

            iCurrentImages.Clear();
            foreach (Campaign campaign in iCurrentCampaigns)
            {

                iCurrentImages.AddRange(campaign.Images);

            }

        }

        public void UpdateCurrentImageIndex()
        {
            //verifica que no se haya terminado de recorrer la lista
            iCurrentImageIndex++;
            if (iCurrentImageIndex >= iCurrentImages.Count)
            {

                UpdateCurrentImages();
                iCurrentImageIndex = 0;

            }

            TimeSpan interval;

            //si hay imagenes para mostrar
            if (iCurrentImages.Count > 0)
            {

                //notifica a los observadores
                foreach (var observer in observers)
                {
                    observer.OnNext(iCurrentImages[iCurrentImageIndex].Bytes);
                }

                //pospone la siguiente actualizacion dependiendo de la duracion de la imagen actual
                interval = TimeSpan.FromSeconds(iCurrentImages[iCurrentImageIndex].Duration);

            }
            else
            {

                //notifica a los observadores con la imagen por default
                foreach (var observer in observers)
                {
                    observer.OnNext(iDefaultImage);
                }

                //pospone la siguiente actualizacion en un tiempo por defecto
                interval = TimeSpan.FromSeconds(5);

            }

            Task.Run(async () => {

                await Task.Delay(interval, cancellationToken);

                if (!cancellationToken.IsCancellationRequested)
                {
                    UpdateCurrentImageIndex();
                }
                
            }, cancellationToken);

        }

        /// <summary>
        /// realiza el loop continuo para traer las siguientes campañas
        /// </summary>
        private void GetNextActiveCampaignsLoop()
        {

            var interval = TimeSpan.FromMinutes(UPDATE_TIME_IN_MINUTES);

            // TODO: Add a CancellationTokenSource and supply the token here instead of None.
            RunPeriodicAsync(GetNextActiveCmapaigns, interval, cancellationToken);

        }

        /// <summary>
        /// realiza el loop continuo para actualizar las listas 
        /// </summary>
        private void UpdateCampaignListsLoop()
        {

            var interval = TimeSpan.FromSeconds(REFRESH_TIME_IN_SECONDS);

            // TODO: Add a CancellationTokenSource and supply the token here instead of None.
            RunPeriodicAsync(UpdateCampaignLists, interval, cancellationToken);

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

        public void RefreshCampaigns()
        {
            tokenSource.Cancel();
            tokenSource.Dispose();

            tokenSource = new CancellationTokenSource();
            cancellationToken = tokenSource.Token;

            GetNextActiveCampaignsLoop();
            UpdateCampaignListsLoop();
            UpdateCurrentImageIndex();
        }
    }

}
