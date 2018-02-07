
using Domain;
using System.Data.Entity.ModelConfiguration;

namespace DAL.EntityFramework.Mappings
{

    /// <summary>
    /// Mapeo para la clase RssItem
    /// </summary>
    class RssItemMap : EntityTypeConfiguration<RssItem>
    {

        public RssItemMap()
        {

            // Nombre de la tabla que tendrá la entidad
            this.ToTable("RssItems");

            // Clave primaria de la entidad, indicando que la columna se llama 'RssItemId' y que es autoincremental.
            this.HasKey(pRssItem => pRssItem.Id)
                .Property(pRssItem => pRssItem.Id)
                .HasColumnName("RssItemId")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Se establece la columna obligatoria (NOT NULL) 'Description'.
            this.Property(pRssItem => pRssItem.Description)
                .IsRequired();

            // Se establece la columna obligatoria (NOT NULL) 'Description'.
            this.Property(pRssItem => pRssItem.Url)
                .IsRequired();

        }

    }
}
