using System;
using System.Collections.Generic;

namespace DTO
{

    [Serializable]
    /// <summary>
    /// DTO para la clase Rss source
    /// </summary>
    public class RssSourceDTO : BannerSourceDTO
    {

        /// <summary>
        /// url de donde se obtienen los item RSS
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Items que se almacenan para dar soporte ofline a la fuente RSS
        /// </summary>
        public IList<RssItemDTO> RssItems { get; set; }

    }
}
