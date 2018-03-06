using Domain;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework.Mappings
{
    /// <summary>
    /// Mapeo de la clase banner
    /// </summary>
    public class RssSourceMap : EntityTypeConfiguration<RssSource>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public RssSourceMap()
        {
            // nombre de la tabla
            this.ToTable("RssSources");

            // columna 'description' obligatoria
            this.Property(pBannerSource => pBannerSource.Description)
                .IsRequired();

            // columna 'url' obligatoria
            this.Property(pRssSource => pRssSource.Url)
                .IsRequired();

            //relacion de uno a muchos con RssItem
            this.HasMany<RssItem>(pRssSource => pRssSource.RssItems)
                .WithRequired()
                .HasForeignKey<int>(i => i.IdRssSource)
                .WillCascadeOnDelete();

        }
    }
}
