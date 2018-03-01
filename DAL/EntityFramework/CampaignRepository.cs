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

    }
}
