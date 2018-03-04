using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace DAL.EntityFramework
{

    /// <summary>
    /// repositorio de entidad banner
    /// </summary>
    public class BannerRepository : Repository<Banner, DigitalSignageDbContext>, IBannerRepository
    {
        public BannerRepository(DigitalSignageDbContext pContext) : base(pContext)
        {
        }

        public IEnumerable<Banner> GetBannersActiveInDate(DateTime pDate)
        {
            return base.iDbContext.Set<Banner>()
                .Where(c => EntityFunctions.TruncateTime(c.InitDate) <= EntityFunctions.TruncateTime(pDate))
                .Where(c => EntityFunctions.TruncateTime(c.EndDate) >= EntityFunctions.TruncateTime(pDate))
                .ToList();
        }

        public IEnumerable<Banner> GetBannersByName(string pName)
        {
            return base.iDbContext.Set<Banner>()
                .Where(c => c.Name.IndexOf(pName) >= 0)
                .ToList();
        }

    }
}
