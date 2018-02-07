using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{   

    /// <summary>
    /// DTO para la clase RssItem
    /// </summary>
    public class RssItemDTO
    {

        public String Title { get; set; }
        public String Description { get; set; }
        public Uri Url { get; set; }
        public DateTime? PublishingDate { get; set; }

    }
}
