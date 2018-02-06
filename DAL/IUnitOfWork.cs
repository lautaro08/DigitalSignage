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
        IBannerRepository bannerRepository { get; }

        /// <summary>
        /// Da acceso al repositorio de fuentes RSS
        /// </summary>
        IRSSSourceRepository rssSourceRepository { get; }

        /// <summary>
        /// Da acceso al repositorio de fuentes de texto
        /// </summary>
        ITextSourceRepository textSourceRepository { get; }

        /// <summary>
        /// Da acceso al repositorio de campañas
        /// </summary>
        ICampaignRepository campaignRepository { get; }

        /// <summary>
        /// persiste los cambios
        /// </summary>
        void Complete();

    }
}
