using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    /// <summary>
    /// representa una campaña de imagenes
    /// </summary>
    public class Campaign
    {

        /// <summary>
        /// id unico de la campaña
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// nombre de la campaña
        /// </summary>
        public String name { get; set; }

        /// <summary>
        /// descripcion de la campaña
        /// </summary>
        public String description { get; set; }

        /// <summary>
        /// fecha de inicio de la campaña
        /// </summary>
        public DateTime initDate { get; set; }


        /// <summary>
        /// fecha de fin de la campaña 
        /// </summary>
        public DateTime endDate { get; set; }

        /// <summary>
        /// hora de inicio de la campaña
        /// </summary>
        public TimeSpan initTime { get; set; }

        /// <summary>
        /// hora de finalizacion de la campaña
        /// </summary>
        public TimeSpan endTime { get; set; }

        /// <summary>
        /// imagenes que componen la campaña
        /// </summary>
        public IList<Image> images { get; set; }

    }
}
