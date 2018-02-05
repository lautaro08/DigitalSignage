using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    /// <summary>
    /// Representa una imagen de una campaña
    /// </summary>
    public class Image
    {

        /// <summary>
        /// id unico que identifica la imagen
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// descripcion de la imagen
        /// </summary>
        public String description { get; set; }

        /// <summary>
        /// bytes que componen la imagen
        /// </summary>
        public Byte[] bytes { get; set; }

        /// <summary>
        /// duracion en segundos de la imagen en pantalla
        /// </summary>
        public int duration { get; set; }

    }
}
