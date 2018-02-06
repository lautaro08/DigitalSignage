using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    /// <summary>
    /// item rss
    /// </summary>
    public class RssItem
    {
        /// <summary>
        /// id unico
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// FK al banner al que pertenece el item RSS
        /// </summary>
        public int BannerId { get; set; }

        /// <summary>
        /// descripcion del item RSS
        /// </summary>
        public String Description { get; set; }
    }
}
