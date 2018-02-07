using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    /// <summary>
    /// DTO para la clase banner
    /// </summary>
    public class BannerDTO
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime InitDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan InitTime { get; set; }
        public TimeSpan EndTime { get; set; }

    }
}
