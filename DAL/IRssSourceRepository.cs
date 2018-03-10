using Domain;
using System;
using System.Collections.Generic;

namespace DAL
{

    /// <summary>
    /// Repositorio generico para el acceso a las fuentes RSS
    /// </summary>
    public interface IRssSourceRepository : IRepository<RssSource>
    {

        /// <summary>
        /// Actualiza una fuente RSS  
        /// </summary>
        /// <param name="updatedRssSource"></param>
        void Update(RssSource updatedRssSource);

        /// <summary>
        /// obtiene los banners que estan asociados a una fuente RSS especifica
        /// </summary>
        /// <param name="pSourceId"></param>
        /// <returns></returns>
        IEnumerable<Banner> GetBannersWithSource(int pSourceId);

    }
}
