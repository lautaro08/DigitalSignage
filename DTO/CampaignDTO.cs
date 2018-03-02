using System;
using System.Collections.Generic;
using Domain;

namespace DTO
{

    [Serializable]
    /// <summary>
    /// DTO para la clase Capaign
    /// </summary>
    public class CampaignDTO
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime InitDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan InitTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public IList<ImageDTO> Images { get; set; }
    }
}
