using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;

namespace DAL.EntityFramework
{
    /// <summary>
    /// Repositorio de entidad camapaña
    /// </summary>
    public class CampaignRepository : Repository<Campaign, DigitalSignageDbContext>, ICampaignRepository
    {
        public CampaignRepository(DigitalSignageDbContext pContext) : base(pContext)
        {
        }

        /// <summary>
        /// Obtiene la campaña por Id
        /// </summary>
        /// <param name="pId">Identificador de la camapaña</param>
        /// <returns>Entidad</returns>
        public virtual Campaign Get(int pId)
        {
            return base.iDbContext.Set<Campaign>().Include("Images").Where(c => c.Id == pId).FirstOrDefault();
        }

        /// <summary>
        /// Obtiene todas las entidades
        /// </summary>
        /// <returns>Coleccion de entidades</returns>
        public virtual IEnumerable<Campaign> GetAll()
        {
            return this.iDbContext.Set<Campaign>().Include("Images").ToList();
        }

        public void Update(Campaign updatedCampaign)
        {
            var oldCampaign = this.iDbContext.Campaigns
                .Include("Images")
                .Where(p => p.Id == updatedCampaign.Id)
                .SingleOrDefault();

            if (oldCampaign != null)
            {
                // Update parent
                this.iDbContext.Entry(oldCampaign).CurrentValues.SetValues(updatedCampaign);

                // Delete Images
                foreach (var existingImage in oldCampaign.Images.ToList())
                {
                    if (!updatedCampaign.Images.Any(c => c.Id == existingImage.Id))
                        this.iDbContext.Images.Remove(existingImage);
                }

                // Update and Insert Images
                foreach (var updatedImage in updatedCampaign.Images)
                {
                    var existingImage = oldCampaign.Images
                        .Where(c => c.Id == updatedImage.Id)
                        .SingleOrDefault();

                    if (existingImage != null)
                        // Update child
                        this.iDbContext.Entry(existingImage).CurrentValues.SetValues(updatedImage);
                    else
                    {
                        // Insert child
                        var newImage = new Image()
                        {
                            Description = updatedImage.Description,
                            Bytes = updatedImage.Bytes,
                            Duration = updatedImage.Duration,
                            Order = updatedImage.Order
                        };
                        oldCampaign.Images.Add(newImage);
                    }
                }

                this.iDbContext.SaveChanges();
            }
        }

    }
}
