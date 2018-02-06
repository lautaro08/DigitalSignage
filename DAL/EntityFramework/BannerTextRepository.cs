using Domain;

namespace DAL.EntityFramework
{

    /// <summary>
    /// repositorio entidad fuente de texto
    /// </summary>
    public class BannerTextRepository : Repository<BannerText, DigitalSignageDbContext>, IBannerTextRepository
    {

        public BannerTextRepository(DigitalSignageDbContext pContext) : base(pContext)
        {
        }
    }
}
