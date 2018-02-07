using System.Data.Entity;
using Domain;
using DAL.EntityFramework.Mappings;
using System;

namespace DAL.EntityFramework
{

    /// <summary>
    /// Clase contexto de acceso a DB
    /// </summary>
    public class DigitalSignageDbContext : DbContext
    {

        /// <summary>
        /// banners
        /// </summary>
        public DbSet<Banner> Banners { get; set; }

        /// <summary>
        /// fuentes RsS
        /// </summary>
        public DbSet<BannerRss> RssSources { get; set; }

        /// <summary>
        /// fuentes de texto
        /// </summary>
        public DbSet<BannerText> TextSources { get; set; }

        /// <summary>
        /// items RSS
        /// </summary>
        public DbSet<RssItem> RssItems { get; set; }

        /// <summary>
        /// campañas
        /// </summary>
        public DbSet<Campaign> Campaigns { get; set; }

        /// <summary>
        /// imagenes
        /// </summary>
        public DbSet<Image> Images { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public DigitalSignageDbContext() : base("DigitalSignage")
        {
            //Database.SetInitializer<DigitalSignageDbContext>(new CreateDatabaseIfNotExists<DigitalSignageDbContext>());
            Database.SetInitializer<DigitalSignageDbContext>(new DropCreateDatabaseIfModelChanges<DigitalSignageDbContext>());
            //Database.SetInitializer<DigitalSignageDbContext>(new DropCreateDatabaseAlways<DigitalSignageDbContext>());
            
        }

        /// <summary>
        /// Constructor para testing
        /// </summary>
        /// <param name="name">nombre de la Base de Datos</param>
        public DigitalSignageDbContext(String name) : base(name)
        {
            // Se establece la estrategia personalizada de inicialización de la BBDD.
            Database.SetInitializer<DigitalSignageDbContext>(new DropCreateDatabaseAlways<DigitalSignageDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {

            //mapeos
            pModelBuilder.Configurations.Add(new BannerRssMap());
            pModelBuilder.Configurations.Add(new BannerTextMap());
            pModelBuilder.Configurations.Add(new BannerMap());
            pModelBuilder.Configurations.Add(new CampaignMap());
            pModelBuilder.Configurations.Add(new RssItemMap());
            pModelBuilder.Configurations.Add(new ImageMap());

            base.OnModelCreating(pModelBuilder);
        }

    }
}
