using Domain;

namespace DAL.EntityFramework
{

    /// <summary>
    /// repositorio de entidad banner
    /// </summary>
    public class BannerRepository : Repository<Banner, DigitalSignageDbContext>, IBannerRepository
    {
        public BannerRepository(DigitalSignageDbContext pContext) : base(pContext)
        {
        }
    }
}
