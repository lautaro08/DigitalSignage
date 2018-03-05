using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;
using System.Data.Entity.Core.Objects;

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

        public IEnumerable<Campaign> GetCampaignsActiveInDate(DateTime pDate)
        {
            return base.iDbContext.Set<Campaign>()
                .Where(c => EntityFunctions.TruncateTime(c.InitDate) <= EntityFunctions.TruncateTime(pDate))
                .Where(c => EntityFunctions.TruncateTime(c.EndDate) >= EntityFunctions.TruncateTime(pDate))
                .ToList();
        }

        public IEnumerable<Campaign> GetCampaignsByName(string pName)
        {
            return base.iDbContext.Set<Campaign>()
                .Include("Images")
                .Where(c => c.Name.IndexOf(pName) >= 0)
                .ToList();
        }

        public void Update(Campaign updatedCampaign)
        {
            //verifica y actualiza el estados de las entidades Imagenes relacionadas con la campaña
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
