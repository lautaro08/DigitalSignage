using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    /// <summary>
    /// Clase que representa a una fuente para un banner
    /// </summary>
    public abstract class BannerSource
    {

        /// <summary>
        /// id de la fuente
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// descripcion de la fuente
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// toda fuente de un banner debe implementar este metodo para devolver su texto
        /// </summary>
        /// <returns>texto que sera mostrado del banner en pantalla</returns>
        public abstract string GetText();

    }
}
