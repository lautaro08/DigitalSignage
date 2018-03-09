using DTO;
using Domain;
using DAL;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;

namespace BLL
{

    /// <summary>
    /// Interface para el servicio de campañas
    /// </summary>
    public interface ICampaignService : IObservable<IEnumerable<Byte []>
    {

        /// <summary>
        /// Crea una campaña
        /// </summary>
        /// <param name="pCampignDTO">camapaña que se quiere crear</param>
        void Create(CampaignDTO pCampignDTO);

        /// <summary>
        /// Eliminar una campaña
        /// </summary>
        /// <param name="pCampignDTO">camapaña que se desea eliminar</param>
        void Remove(CampaignDTO pCampignDTO);

        /// <summary>
        /// Actualiza una campaña
        /// </summary>
        /// <param name="pCampaignDTO">campaña que se desea actualizar</param>
        void Update(CampaignDTO pCampaignDTO);

        /// <summary>
        /// Obtiene una campaña por su id
        /// </summary>
        /// <param name="pId">id de la campaña que se quiere obtener</param>
        /// <returns></returns>
        CampaignDTO Get(int pId);


        /// <summary>
        /// Obtiene todas las campañas
        /// </summary>
        IEnumerable<CampaignDTO> GetAll();

        /// <summary>
        /// Obtiene todas las camapañas activas en un dia determinado
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        IEnumerable<CampaignDTO> GetCampaignsActiveInDate(DateTime pDate);

        /// <summary>
        /// Obtiene todas las camapañas cuyo nombre coincida por aproximacion al dado en el parametro
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        IEnumerable<CampaignDTO> GetCampaignsByName(string pName);

        /// <summary>
        /// cancela los procesos de actualizacion actuales y los vuelve a comenzar
        /// </summary>
        void RefreshCampaigns();

    }
}
