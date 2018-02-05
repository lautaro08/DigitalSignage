using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    /// <summary>
    /// Clase generica para una fuente del banner
    /// </summary>
    public class BannerSource
    {

        /// <summary>
        /// id unico de la fuente
        /// </summary>
        public int id { get; set; }
        
        /// <summary>
        /// descripcion de la fuente
        /// </summary>
        public String description { get; set; }

        /// <summary>
        /// tipo de la fuente (texto o RSS)
        /// </summary>
        public SourceType type { get; set; }
    }
}
