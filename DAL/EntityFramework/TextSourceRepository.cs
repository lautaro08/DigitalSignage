using Domain;

namespace DAL.EntityFramework
{

    /// <summary>
    /// repositorio entidad fuente de texto
    /// </summary>
    class TextSourceRepository : Repository<TextSource, DigitalSignageDbContext>, ITextSourceRepository
    {

        public TextSourceRepository(DigitalSignageDbContext pContext) : base(pContext)
        {
        }
    }
}
