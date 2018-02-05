
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;

namespace DAL
{

    /// <summary>
    /// Repositorio generico para el acceso a los banner
    /// </summary>
    public interface IBannerRepository : IRepository<Banner>
    {
    }

}
