using System.Data.Entity;
using Domain;

namespace DAL.EntityFramework
{

    /// <summary>
    /// Clase contexto de acceso a DB
    /// </summary>
    class DigitalSignageDbContext : DbContext
    {

        /// <summary>
        /// banners
        /// </summary>
        public DbSet<Banner> banners { get; set; }

        /// <summary>
        /// fuentes RsS
        /// </summary>
        public DbSet<BannerRSS> rssSources { get; set; }

        /// <summary>
        /// fuentes de texto
        /// </summary>
        public DbSet<BannerText> textSources { get; set; }

        /// <summary>
        /// items RSS
        /// </summary>
        public DbSet<RSSItem> rssItems { get; set; }

        /// <summary>
        /// campañas
        /// </summary>
        public DbSet<Campaign> campaigns { get; set; }

        /// <summary>
        /// imagenes
        /// </summary>
        public DbSet<Image> images { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public DigitalSignageDbContext() : base("DigitalSignage")
        {
            //Database.SetInitializer<AccountManagerDbContext>(new CreateDatabaseIfNotExists<AccountManagerDbContext>());
            Database.SetInitializer<DigitalSignageDbContext>(new DropCreateDatabaseIfModelChanges<DigitalSignageDbContext>());
            //Database.SetInitializer<AccountManagerDbContext>(new DropCreateDatabaseAlways<AccountManagerDbContext>());
            
        }

    }
}
