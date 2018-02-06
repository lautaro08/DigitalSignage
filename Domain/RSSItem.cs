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
    public class RSSItem
    {
        /// <summary>
        /// id unico
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// descripcion del item RSS
        /// </summary>
        public String description { get; set; }
    }
}
