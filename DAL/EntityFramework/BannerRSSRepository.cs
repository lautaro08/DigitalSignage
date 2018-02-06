using Domain;

namespace DAL.EntityFramework
{

    /// <summary>
    /// repositorio de entidad fuente RSS
    /// </summary>
    class BannerRSSRepository : Repository<BannerRSS, DigitalSignageDbContext>, IBannerRSSRepository
    {

        public BannerRSSRepository(DigitalSignageDbContext pContext) : base(pContext)
        {
        }
    }
}
