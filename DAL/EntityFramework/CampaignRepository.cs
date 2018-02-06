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
    }
}
