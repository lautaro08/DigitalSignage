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
        public int Id { get; set; }
        /// <summary>
        /// FK al banner al que pertenece la imagen
        /// </summary>
        public int CampaignID { get; set; }

        /// <summary>
        /// descripcion de la imagen
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// bytes que componen la imagen
        /// </summary>
        public Byte[] Bytes { get; set; }

        /// <summary>
        /// duracion en segundos de la imagen en pantalla
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// orden de la imagen en la campaña
        /// </summary>
        public int Order { get; set; }

    }
}
