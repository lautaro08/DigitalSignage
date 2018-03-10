using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

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

        public IEnumerable<Campaign> GetActiveCampaignsInRange(DateTime pDate, TimeSpan pInitTime, TimeSpan pEndTime)
        {
            if (pDate == null)
                throw new ArgumentNullException("pDate");
            if (pInitTime == null)
                throw new ArgumentNullException("pTimeFrom");
            if (pEndTime == null)
                throw new ArgumentNullException("pTimeTo");
            if (pInitTime.CompareTo(pEndTime) > -1)
                throw new InvalidOperationException("pTimeFrom debe ser menor que pTimeTo");

            return base.iDbContext.Set<Campaign>()
                //compara para saber si el banner esta activo en la fecha
                .Where(b => DbFunctions.TruncateTime(b.InitDate) <= DbFunctions.TruncateTime(pDate))
                .Where(b => DbFunctions.TruncateTime(b.EndDate) >= DbFunctions.TruncateTime(pDate))
                //compara para saber si el banner esta activo en el rango horario
                .Where(b => b.InitTime <= pEndTime && b.EndTime >= pInitTime)
                .ToList();

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
