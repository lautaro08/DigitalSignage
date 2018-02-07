using DTO;
using Domain;
using DAL;
using DAL.EntityFramework;
using System;

namespace BLL
{
    public class CampaignService
    {
        /// <summary>
        /// Logger
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor para usar contexto por defecto
        /// </summary>
        public CampaignService()
        {

            this.iUnitOfWork = new UnitOfWork(new DigitalSignageDbContext());

        }

        /// <summary>
        /// Constructor para utilizar contexto por parametro (PARA TESTING)
        /// </summary>
        /// <param name="pUnitOfWork">unidad de trabajo</param>
        public CampaignService(UnitOfWork pUnitOfWork)
        {

            this.iUnitOfWork = pUnitOfWork;

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
            catch(ArgumentNullException e)
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
                var oldCampaign = iUnitOfWork.CampaignRepository.Get(campaign.Id);

                //actualizando campos
                oldCampaign.Name = campaign.Name;
                oldCampaign.Description = campaign.Description;
                oldCampaign.InitDate = campaign.InitDate;
                oldCampaign.EndDate = campaign.EndDate;
                oldCampaign.InitTime = campaign.InitTime;
                oldCampaign.EndTime = campaign.EndTime;

                if (oldCampaign.Images != null) { oldCampaign.Images.Clear(); }
                oldCampaign.Images = campaign.Images;

                //Guardando los cambios
                iUnitOfWork.Complete();

            }
            catch(Exception e)
            {

                log.Info("Error al actualizar camapaña: " + e.Message);
                throw new Exception();

            }

        }

    }
}
