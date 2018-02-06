using Domain;

namespace DAL.EntityFramework
{

    /// <summary>
    /// repositorio de entidad fuente RSS
    /// </summary>
    public class BannerRssRepository : Repository<BannerRss, DigitalSignageDbContext>, IBannerRssRepository
    {

        public BannerRssRepository(DigitalSignageDbContext pContext) : base(pContext)
        {
        }
    }
}
