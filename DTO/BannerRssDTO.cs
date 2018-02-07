using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    /// <summary>
    /// DTO para la clase BannerRss
    /// </summary>
    public class BannerRssDTO : BannerDTO
    {
        
        public String Url { get; set; }
        public IEnumerable<RssItemDTO> RssItems { get; set; }

    }
}
