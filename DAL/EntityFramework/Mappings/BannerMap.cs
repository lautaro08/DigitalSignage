using Domain;
using System.Data.Entity.ModelConfiguration;

namespace DAL.EntityFramework.Mappings
{
    /// <summary>
    /// Mapeo de la clase banner
    /// </summary>
    public class BannerMap : EntityTypeConfiguration<Banner>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BannerMap()
        {
            // nombre de la tabla
            this.ToTable("Banner");

            // Clave primaria de la entidad, indicando que la columna se llama 'BannerId' y que es autoincremental.
            this.HasKey(pBanner => pBanner.Id)
                .Property(pBanner => pBanner.Id)
                .HasColumnName("BannerId")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // columna 'name' obligatoria
            this.Property(pBanner => pBanner.Name)
                .IsRequired();

            // columna 'initDate' obligatoria
            this.Property(pBanner => pBanner.InitDate)
                .IsRequired();

            // columna 'endDate' obligatoria
            this.Property(pBanner => pBanner.EndDate)
                .IsRequired();

            // columna 'initTime' obligatoria
            this.Property(pBanner => pBanner.InitTime)
                .IsRequired();

            // columna 'endTime' obligatoria
            this.Property(pBanner => pBanner.EndTime)
                .IsRequired();

            ////para la herencia se define un atributo tipo segun el tipo de subclase
            Map<BannerRss>(x => x.Requires("type")
                                        .HasValue("R")
                                        .HasColumnType("char")
                                        .HasMaxLength(1));

            Map<BannerText>(x => x.Requires("type")
                                          .HasValue("T")
                            );

        }
    }
}
