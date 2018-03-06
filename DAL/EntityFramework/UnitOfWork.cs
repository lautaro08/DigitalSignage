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
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DigitalSignageDbContext iDbContext;

        /// <summary>
        /// constructor
        /// </summary>
        public UnitOfWork(DigitalSignageDbContext pContext)
        {

            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }

            this.iDbContext = pContext;
            this.CampaignRepository = new CampaignRepository(this.iDbContext);
            this.BannerRepository = new BannerRepository(this.iDbContext);
            this.RssSourceRepository = new RssSourceRepository(this.iDbContext);

        }

        /// <summary>
        /// repositorio de banners
        /// </summary>
        public IBannerRepository BannerRepository
        {
            get; private set;
        }

        /// <summary>
        /// repositorio de fuentes RSS
        /// </summary>
        public IRssSourceRepository RssSourceRepository
        {
            get; private set;
        }

        /// <summary>
        /// repositorio de campañas
        /// </summary>
        public ICampaignRepository CampaignRepository
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
