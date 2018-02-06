using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    /// <summary>
    /// banner con fuente RSS
    /// </summary>
    public class BannerRss : Banner
    {

        /// <summary>
        /// url para obtener el feed RSS
        /// </summary>
        public String Url { get; set; }

        /// <summary>
        /// lista de items almacenados para esta fuente
        /// </summary>
        public IList<RssItem> RssItems { get; set; }
    }
}
