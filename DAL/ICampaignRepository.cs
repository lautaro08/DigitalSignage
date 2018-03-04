using Domain;
using System;
using System.Collections.Generic;

namespace DAL
{

    /// <summary>
    /// Repositorio generico para el acceso a las campañas
    /// </summary>
    public interface ICampaignRepository : IRepository<Campaign>
    {

        /// <summary>
        /// Actualiza una campaña  
        /// </summary>
        /// <param name="updatedCampaign"></param>
        void Update(Campaign updatedCampaign);

        /// <summary>
        /// Obtiene las campañas activas en una fecha determinada
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        IEnumerable<Campaign> GetCampaignsActiveInDate(DateTime pDate);

        /// <summary>
        /// Obtiene las campañas cuyo nombre coincida (o contenga) el nombre buscado
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        IEnumerable<Campaign> GetCampaignsByName(string pName);

    }
}
