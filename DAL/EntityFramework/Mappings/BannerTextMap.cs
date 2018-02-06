using Domain;
using System.Data.Entity.ModelConfiguration;

namespace DAL.EntityFramework
{

    /// <summary>
    /// Mapeo de la clase BannerText
    /// </summary>
    class BannerTextMap : EntityTypeConfiguration<BannerText>
    {

        public BannerTextMap() {

            // columna 'text' obligatoria
            this.Property(pBannerText => pBannerText.Text)
                .IsRequired();

        }

    }
}
