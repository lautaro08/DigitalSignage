using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    /// <summary>
    /// DTO para la clase Image
    /// </summary>
    public class ImageDTO
    {

        public int Id { get; set; }
        public String Description { get; set; }
        public Byte[] Bytes { get; set; }
        public int Duration { get; set; }

    }
}
