using Domain;
using System.Data.Entity.ModelConfiguration;

namespace DAL.EntityFramework.Mappings
{   
    /// <summary>
    /// Mapeo de la calse Image
    /// </summary>
    class ImageMap : EntityTypeConfiguration<Image>
    {

        public ImageMap()
        {

            // Nombre de la tabla que tendrá la entidad
            this.ToTable("Images");

            // Clave primaria de la entidad, indicando que la columna se llama 'ImageId' y que es autoincremental.
            this.HasKey(pImage => pImage.Id)
                .Property(pImage => pImage.Id)
                .HasColumnName("ImageId")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Se establece la columna obligatoria (NOT NULL) 'Description'.
            this.Property(pImage => pImage.Description)
                .IsRequired();

            // Se establece la columna obligatoria (NOT NULL) 'Bytes'.
            this.Property(pImage => pImage.Bytes)
                .IsRequired();

        }

    }
}
