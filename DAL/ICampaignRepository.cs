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

        /// <summary>
        /// Obtiene las campañas activas en una fecha y rango de hora específico
        /// </summary>
        /// <param name="pDate">Fecha</param>
        /// <param name="pTimeFrom">Tiempo de inicio para la busqueda</param>
        /// <param name="pTimeTo">tiempo de fin para la busqueda</param>
        /// <returns>Lista de bannersactivos en el horario y fecha dados</returns>
        IEnumerable<Campaign> GetActiveCampaignsInRange(DateTime pDate, TimeSpan pTimeFrom, TimeSpan pTimeTo);

    }
}
