using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{

    /// <summary>
    /// Implementación del patrón Unidad de Trabajo
    /// </summary>
    class UnitOfWork : IUnitOfWork
    {

        private readonly DigitalSignageDbContext iDbContext;

        /// <summary>
        /// constructor
        /// </summary>
        public UnitOfWork(DigitalSignageDbContext pContext)
        {

        }

        /// <summary>
        /// repositorio de banners
        /// </summary>
        public IBannerRepository bannerRepository
        {
            get; private set;
        }

        /// <summary>
        /// repositorio de campañas
        /// </summary>
        public ICampaignRepository campaignRepository
        {
            get; private set;
        }

        /// <summary>
        /// repositorio de fuentes RSS
        /// </summary>
        public IBannerRSSRepository rssSourceRepository
        {
            get; private set;
        }

        /// <summary>
        /// repositorio de fuentes de texto
        /// </summary>
        public IBannerTextRepository textSourceRepository
        {
            get; private set;
        }

        /// <summary>
        /// persiste los cambios
        /// </summary>
        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }

        /// <summary>
        /// elimina los recursos tomados
        /// </summary>
        public void Dispose()
        {
            this.iDbContext.Dispose();
        }
    }
}
