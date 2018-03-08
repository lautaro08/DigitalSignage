﻿using DTO;
using Domain;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.IO;

namespace BLL
{
    public class CampaignService : ICampaignService
    {
        /// <summary>
        /// Logger
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private UnitOfWork iUnitOfWork;

        //lista de subscriptos para obtener la imagen de la campaña actual
        private List<IObserver<byte[]>> observers;

        private byte[] iCurrentImage = File.ReadAllBytes("../../../assets/image.jpg");


        /// <summary>
        /// Constructor para usar contexto por defecto
        /// </summary>
        public CampaignService()
        {

            this.iUnitOfWork = new UnitOfWork(new DigitalSignageDbContext());

            observers = new List<IObserver<byte[]>>();
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
                // Envia al nuevo s observador el texto actual.
                observer.OnNext(iCurrentImage);
            }
            return new Unsubscriber<byte[]>(observers, observer);
        }
    }

}
