using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    /// <summary>
    /// interfaz para el servicio de banners
    /// </summary>
    public interface IBannerService
    {

        /// <summary>
        /// Crea un banner
        /// </summary>
        /// <param name="pBannerDTO">banner que se quiere crear</param>
        void Create(BannerDTO pBannerDTO);

        /// <summary>
        /// Eliminar un banner
        /// </summary>
        /// <param name="pBannerDTO">banner que se desea eliminar</param>
        void Remove(BannerDTO pBannerDTO);

        /// <summary>
        /// Actualiza un banner
        /// </summary>
        /// <param name="pBannerDTO">banner que se desea actualizar</param>
        void Update(BannerDTO pBannerDTO);

        /// <summary>
        /// Obtiene un banner por su id
        /// </summary>
        /// <param name="pId">id del banner que se quiere obtener</param>
        /// <returns></returns>
        BannerDTO Get(int pId);


        /// <summary>
        /// Obtiene todos los banners
        /// </summary>
        IEnumerable<BannerDTO> GetAll();

        /// <summary>
        /// Obtiene todaos los banners activos en un dia determinado
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        IEnumerable<BannerDTO> GetBannersActiveInDate(DateTime pDate);

        /// <summary>
        /// Obtiene todos los banners cuyo nombre coincida por aproximacion al dado en el parametro
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        IEnumerable<BannerDTO> GetBannersByName(string pName);

    }
}
