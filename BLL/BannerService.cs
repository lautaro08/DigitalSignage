using System;
using System.Collections.Generic;
using DTO;
using DAL.EntityFramework;
using Domain;

namespace BLL
{
    public class BannerService : IBannerService
    {

        /// <summary>
        /// Logger
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor para usar contexto por defecto
        /// </summary>
        public BannerService()
        {
            this.iUnitOfWork = new UnitOfWork(new DigitalSignageDbContext());
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

                //Guardando los cambios
                iUnitOfWork.Complete();

            }
            catch (Exception e)
            {

                log.Error("Error al actualizar banner: " + e.Message);
                throw new Exception();

            }
        }
    }
}
