using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework.Mappings
{
    /// <summary>
    /// Mapeo de la clase banner source
    /// </summary>
    public class BannerSourceMap : EntityTypeConfiguration<BannerSource>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BannerSourceMap()
        {

            // Clave primaria de la entidad, indicando que la columna se llama 'BannerId' y que es autoincremental.
            this.HasKey(pBannerSource => pBannerSource.Id)
                .Property(pBannerSource => pBannerSource.Id)
                .HasColumnName("BannerSourceId")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // columna 'description' obligatoria
            this.Property(pBannerSource => pBannerSource.Description)
                .IsRequired();

        }
    }
}
