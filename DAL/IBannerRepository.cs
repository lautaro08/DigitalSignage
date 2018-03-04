
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;

namespace DAL
{

    /// <summary>
    /// Repositorio generico para el acceso a los banner
    /// </summary>
    public interface IBannerRepository : IRepository<Banner>
    {

        /// <summary>
        /// Obtiene los banners activos en una fecha determinada
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        IEnumerable<Banner> GetBannersActiveInDate(DateTime pDate);

        /// <summary>
        /// Obtiene los banners cuyo nombre coincida (o contenga) el nombre buscado
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        IEnumerable<Banner> GetBannersByName(string pName);

    }

}
