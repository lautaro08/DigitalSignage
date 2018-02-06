using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    /// <summary>
    /// Representa una transaccion con la base de datos
    /// </summary>
    public interface IUnitOfWork : IDisposable {

        /// <summary>
        /// Da acceso al repositorio de banners
        /// </summary>
        IBannerRepository BannerRepository { get; }

        /// <summary>
        /// Da acceso al repositorio de fuentes RSS
        /// </summary>
        IBannerRssRepository BannerRssRepository { get; }

        /// <summary>
        /// Da acceso al repositorio de fuentes de texto
        /// </summary>
        IBannerTextRepository BannerTextRepository { get; }

        /// <summary>
        /// Da acceso al repositorio de campañas
        /// </summary>
        ICampaignRepository CampaignRepository { get; }

        /// <summary>
        /// persiste los cambios
        /// </summary>
        void Complete();

    }
}
