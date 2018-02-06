using Domain;

namespace DAL.EntityFramework
{

    /// <summary>
    /// repositorio de entidad fuente RSS
    /// </summary>
    class RSSSourceRepository : Repository<RSSSource, DigitalSignageDbContext>, IRSSSourceRepository
    {

        public RSSSourceRepository(DigitalSignageDbContext pContext) : base(pContext)
        {
        }
    }
}
