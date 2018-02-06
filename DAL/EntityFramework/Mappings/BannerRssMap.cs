using Domain;
using System.Data.Entity.ModelConfiguration;

namespace DAL.EntityFramework.Mappings
{

    /// <summary>
    /// Mapeo de la clase banner Rss
    /// </summary>
    class BannerRssMap : EntityTypeConfiguration<BannerRss>
    {

        public BannerRssMap()
        {

            //Especifica que un banner rss tiene muchos items.
            this.HasMany<RssItem>(pBanner => pBanner.RssItems)
                .WithRequired()
                .HasForeignKey<int>(i => i.BannerId)
                .WillCascadeOnDelete();

            // columna 'Url' obligatoria
            this.Property(pBanner => pBanner.Url)
                .IsRequired();

        }

    }
}
