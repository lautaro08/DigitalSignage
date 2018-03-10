using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;
using System.Data.Entity.Core.Objects;

namespace DAL.EntityFramework
{
    /// <summary>
    /// Repositorio de entidad fuente RSS
    /// </summary>
    public class RssSourceRepository : Repository<RssSource, DigitalSignageDbContext>, IRssSourceRepository
    {
        public RssSourceRepository(DigitalSignageDbContext pContext) : base(pContext)
        {
        }

        public IEnumerable<Banner> GetBannersWithSource(int pSourceId)
        {
            return this.iDbContext.Banners
                .Where(b => b.SourceId == pSourceId)
                .ToList();
        }

        public void Update(RssSource updatedRssSource)
        {
            //verifica y actualiza el estados de las entidades Imagenes relacionadas con la campaña
            var oldRssSource = this.iDbContext.RssSources
                .Where(p => p.Id == updatedRssSource.Id)
                .SingleOrDefault();

            if (oldRssSource != null)
            {
                // Update parent
                this.iDbContext.Entry(oldRssSource).CurrentValues.SetValues(updatedRssSource);

                // Delete Images
                foreach (var rssItem in oldRssSource.RssItems.ToList())
                {
                    this.iDbContext.RssItems.Remove(rssItem);
                }

                oldRssSource.RssItems = updatedRssSource.RssItems;

                this.iDbContext.SaveChanges();
            }
        }

    }
}
