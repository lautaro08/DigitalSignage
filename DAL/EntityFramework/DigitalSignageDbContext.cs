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
            //Database.SetInitializer<DigitalSignageDbContext>(new DropCreateDatabaseIfModelChanges<DigitalSignageDbContext>());
            //Database.SetInitializer<DigitalSignageDbContext>(new DropCreateDatabaseAlways<DigitalSignageDbContext>());

            // Se establece la estrategia personalizada de inicialización de la BBDD.
            this.Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer<DigitalSignageDbContext>(new DatabaseInitialization());

        }

        /// <summary>
        /// Constructor para testing
        /// </summary>
        /// <param name="name">nombre de la Base de Datos</param>
        public DigitalSignageDbContext(String name) : base(name)
        {
            this.Configuration.LazyLoadingEnabled = true;
            // Se establece la estrategia personalizada de inicialización de la BBDD.
            Database.SetInitializer<DigitalSignageDbContext>(new DropCreateDatabaseIfModelChanges<DigitalSignageDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {

            //mapeos
            pModelBuilder.Configurations.Add(new BannerMap());
            pModelBuilder.Configurations.Add(new CampaignMap());
            pModelBuilder.Configurations.Add(new RssItemMap());
            pModelBuilder.Configurations.Add(new ImageMap());
            pModelBuilder.Configurations.Add(new BannerSourceMap());
            pModelBuilder.Configurations.Add(new RssSourceMap());
            pModelBuilder.Configurations.Add(new TextSourceMap());

            base.OnModelCreating(pModelBuilder);
        }

    }
}
