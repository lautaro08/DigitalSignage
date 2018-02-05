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
        public int id { get; set; }

        /// <summary>
        /// descripcion del banner
        /// </summary>
        public String description { get; set; }

        /// <summary>
        /// fecha de inicio del banner
        /// </summary>
        public DateTime initDate { get; set; }


        /// <summary>
        /// fecha de fin del banner
        /// </summary>
        public DateTime endDate { get; set; }

        /// <summary>
        /// hora de inicio del banner
        /// </summary>
        public TimeSpan initTime { get; set; }

        /// <summary>
        /// hora de finalizacion del banner
        /// </summary>
        public TimeSpan endTime { get; set; }

        /// <summary>
        /// fuente del texto para el banner
        /// </summary>
        public BannerSource source { get; set; }

    }
}
