
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
        /// Obtiene todos los banners activos en una fecha determinada
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

        /// <summary>
        /// Obtiene los banners activos en una fecha y rango de hora específico
        /// </summary>
        /// <param name="pDate">Fecha</param>
        /// <param name="pTimeFrom">Tiempo de inicio para la busqueda</param>
        /// <param name="pTimeTo">tiempo de fin para la busqueda</param>
        /// <returns>Lista de bannersactivos en el horario y fecha dados</returns>
        IEnumerable<Banner> GetActiveBannersInRange(DateTime pDate, TimeSpan pTimeFrom, TimeSpan pTimeTo);

    }

}
