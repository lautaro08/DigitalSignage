using DTO;
using Domain;
using DAL;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class RssSourceService : IRssSourceService
    {
        /// <summary>
        /// Logger
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor para usar contexto por defecto
        /// </summary>
        public RssSourceService()
        {

            this.iUnitOfWork = new UnitOfWork(new DigitalSignageDbContext());

        }

        /// <summary>
        /// Crea una fuente RSS
        /// </summary>
        /// <param name="pRssSourceDTO">fuente RSS que se quiere crear</param>
        public void Create(RssSourceDTO pRssSourceDTO)
        {
            ///Mapea el DTO a un objecto RssSource
            var rssSource = new RssSource();
            AutoMapper.Mapper.Map(pRssSourceDTO, rssSource);

            try
            {
                log.Info("Guardando fuente RSS");
                this.iUnitOfWork.RssSourceRepository.Add(rssSource);
                this.iUnitOfWork.Complete();
                log.Info("fuente RSS creada con exito");

            }
            catch (ArgumentException e)
            {
                log.Error("Error al crear fuente RSS: " + e.Message);
                throw new ArgumentException();

            }

        }

        /// <summary>
        /// Eliminar una fuente RSS
        /// </summary>
        /// <param name="pRssSourceDTO">fuente RSS que se desea eliminar</param>
        public void Remove(RssSourceDTO pRssSourceDTO)
        {

            try
            {
                var asociatedBanners = iUnitOfWork.RssSourceRepository.GetBannersWithSource(pRssSourceDTO.Id);

                if (asociatedBanners.ToList().Count == 0)
                {

                    log.Info("Eliminando fuente RSS");
                    RssSource RssSource = iUnitOfWork.RssSourceRepository.Get(pRssSourceDTO.Id);
                    iUnitOfWork.RssSourceRepository.Remove(RssSource);
                    iUnitOfWork.Complete();
                    log.Info("fuente RSS eliminada con exito");

                }
                else
                {
                    throw new Exception("No se puede eliminar la fuente RSS ya que esta siendo usada por banners");


                }
                

            }
            catch(ArgumentNullException e)
            {

                log.Error("Error al eliminar fuente RSS: " + e.Message);
                throw new ArgumentException();

            }
            
        }

        /// <summary>
        /// Actualiza una fuente RSS
        /// </summary>
        /// <param name="pRssSourceDTO">fuente RSS que se desea actualizar</param>
        public void Update(RssSourceDTO pRssSourceDTO)
        {
            ///fuente RSS actualizada
            var RssSource = new RssSource();
            AutoMapper.Mapper.Map(pRssSourceDTO, RssSource);

            try
            {
                //fuente RSS anterior
                log.Info("Actualizando fuente RSS");
                iUnitOfWork.RssSourceRepository.Update(RssSource);

                //Guardando los cambios
                iUnitOfWork.Complete();

            }
            catch(Exception e)
            {

                log.Error("Error al actualizar fuente RSS: " + e.Message);
                throw new Exception();

            }

        }

        /// <summary>
        /// Obtiene una fuente RSS por su id
        /// </summary>
        /// <param name="pId">id de la fuente RSS que se quiere obtener</param>
        /// <returns></returns>
        public RssSourceDTO Get(int pId)
        {

            try
            {

                log.Info("Obteniendo fuente RSS");
                var RssSource = iUnitOfWork.RssSourceRepository.Get(pId);
                log.Info("fuente RSS obtenida con exito");

                var RssSourceDTO = new RssSourceDTO();
                AutoMapper.Mapper.Map(RssSource, RssSourceDTO);
                return RssSourceDTO;

            }
            catch(Exception e)
            {

                log.Error("Error al obtener fuente RSS: " + e.Message);
                throw new Exception();

            }

        }


        /// <summary>
        /// Obtiene todas las fuente RSSs
        /// </summary>
        public IEnumerable<RssSourceDTO> GetAll()
        {

            try
            {

                log.Info("Obteniendo todas las fuente RSSs");
                IEnumerable<RssSource> RssSources = iUnitOfWork.RssSourceRepository.GetAll();
                log.Info("fuente RSSs obtenidas con exito");

                var RssSourcesDTO = AutoMapper.Mapper.Map<IEnumerable<RssSource>, IEnumerable<RssSourceDTO>>(RssSources);

                return RssSourcesDTO;

            }
            catch (Exception e)
            {

                log.Error("Error al obtener fuente RSS: " + e.Message);
                throw new Exception();

            }

        }
        
    }
}
