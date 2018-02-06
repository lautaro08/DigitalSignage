using Domain;
using System.Data.Entity.ModelConfiguration;

namespace DAL.EntityFramework.Mappings
{

    /// <summary>
    /// Mapeo de la clase Campaign
    /// </summary>
    class CampaignMap : EntityTypeConfiguration<Campaign>
    {

        public CampaignMap()
        {
            //nombre de la tabla
            ToTable("Campaigns");

            // Clave primaria de la entidad, indicando que la columna se llama 'BannerId' y que es autoincremental.
            this.HasKey(pCampign => pCampign.Id)
                .Property(pCampign => pCampign.Id)
                .HasColumnName("CampaignId")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // columna 'name' obligatoria
            this.Property(pCampign => pCampign.Name)
                .IsRequired();

            // columna 'initDate' obligatoria
            this.Property(pCampign => pCampign.InitDate)
                .IsRequired();

            // columna 'endDate' obligatoria
            this.Property(pCampign => pCampign.EndDate)
                .IsRequired();

            // columna 'initTime' obligatoria
            this.Property(pCampign => pCampign.InitTime)
                .IsRequired();

            // columna 'endTime' obligatoria
            this.Property(pCampign => pCampign.EndTime)
                .IsRequired();

            //Especifica que una campaña tiene muchas imagenes y que la clave foranea es campaignId.
            this.HasMany<Image>(pCampaign => pCampaign.Images)
                .WithRequired()
                .HasForeignKey<int>(i => i.CampaignId)
                .WillCascadeOnDelete();
        }

    }
}
