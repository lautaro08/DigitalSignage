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
        public int Id { get; set; }

        /// <summary>
        /// nombre de la campaña
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// descripcion de la campaña
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// fecha de inicio de la campaña
        /// </summary>
        public DateTime InitDate { get; set; }


        /// <summary>
        /// fecha de fin de la campaña 
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// hora de inicio de la campaña
        /// </summary>
        public TimeSpan InitTime { get; set; }

        /// <summary>
        /// hora de finalizacion de la campaña
        /// </summary>
        public TimeSpan EndTime { get; set; }

        /// <summary>
        /// imagenes que componen la campaña
        /// </summary>
        public virtual IList<Image> Images { get; set; }

        /// <summary>
        /// verifica que el banner este activo en este momento
        /// </summary>
        /// <returns>verdadero si esta activo, falso en caso contrario</returns>
        public bool IsActiveNow()
        {

            bool isActive;
            var today = DateTime.Now;
            //se encuentra activo en la fecha
            isActive = this.InitDate.Date <= today.Date && today.Date <= this.EndDate.Date;
            isActive &= this.InitTime <= today.TimeOfDay && today.TimeOfDay <= this.EndTime;
            return isActive;

        }

    }
}
