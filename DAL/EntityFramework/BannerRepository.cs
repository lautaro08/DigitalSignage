using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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


        public IEnumerable<Banner> GetActiveBannersInRange(DateTime pDate, TimeSpan pInitTime, TimeSpan pEndTime)
        {
            if (pDate == null)
                throw new ArgumentNullException("pDate");
            if (pInitTime == null)
                throw new ArgumentNullException("pTimeFrom");
            if (pEndTime == null)
                throw new ArgumentNullException("pTimeTo");
            if (pInitTime.CompareTo(pEndTime) > -1)
                throw new InvalidOperationException("pTimeFrom debe ser menor que pTimeTo");

            return base.iDbContext.Set<Banner>()
                //compara para saber si el banner esta activo en la fecha
                .Where(b => DbFunctions.TruncateTime(b.InitDate) <= DbFunctions.TruncateTime(pDate))
                .Where(b => DbFunctions.TruncateTime(b.EndDate) >= DbFunctions.TruncateTime(pDate))
                //compara para saber si el banner esta activo en el rango horario
                .Where(b => b.InitTime <= pEndTime && b.EndTime >= pInitTime)
                .ToList();

        }

        public IEnumerable<Banner> GetBannersActiveInDate(DateTime pDate)
        {
            if (pDate == null)
                throw new ArgumentNullException("pDate");

            return base.iDbContext.Set<Banner>()
                .Where(c => DbFunctions.TruncateTime(c.InitDate) <= DbFunctions.TruncateTime(pDate))
                .Where(c => DbFunctions.TruncateTime(c.EndDate) >= DbFunctions.TruncateTime(pDate))
                .ToList();
        }

        public IEnumerable<Banner> GetBannersByName(string pName)
        {
            if (pName == null)
                throw new ArgumentNullException("pName");

            return base.iDbContext.Set<Banner>()
                .Where(c => c.Name.IndexOf(pName) >= 0)
                .ToList();
        }

    }
}
