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

        /// <summary>
        /// foreign key para fuente de banner
        /// </summary>
        public int SourceId { get; set; }

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

        /// <summary>
        /// Obtiene el texto del banner
        /// </summary>
        /// <returns></returns>
        public string GetText()
        {

            return Source.GetText();

        }

    }
}
