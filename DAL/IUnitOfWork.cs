using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{   

    /// <summary>
    /// Representa una transaccion con la base de datos
    /// </summary>
    public class IUnitOfWork : IDisposable

    {

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
