using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    /// <summary>
    /// fuente de RSS para el banner
    /// </summary>
    public class RSSSource : BannerSource
    {

        /// <summary>
        /// url para obtener el feed RSS
        /// </summary>
        public String url { get; set; }

        /// <summary>
        /// lista de items almacenados para esta fuente
        /// </summary>
        public IList<RSSItem> rssItems { get; set; }
    }
}
