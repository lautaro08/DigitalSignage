using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{   

    /// <summary>
    /// Clase que representa un banner
    /// </summary>
    public class Banner
    {

        /// <summary>
        /// id unico del banner
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// nombre del banner
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// descripcion del banner
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// fecha de inicio del banner
        /// </summary>
        public DateTime InitDate { get; set; }


        /// <summary>
        /// fecha de fin del banner
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// hora de inicio del banner
        /// </summary>
        public TimeSpan InitTime { get; set; }

        /// <summary>
        /// hora de finalizacion del banner
        /// </summary>
        public TimeSpan EndTime { get; set; }

        /// <summary>
        /// fuente del banner
        /// </summary>
        public virtual BannerSource Source { get; set; }

    }
}
