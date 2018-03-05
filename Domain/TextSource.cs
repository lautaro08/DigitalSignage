using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    /// <summary>
    /// fuente para banner de texto plano
    /// </summary>
    public class TextSource : BannerSource
    {

        /// <summary>
        /// texto de la fuente
        /// </summary>
        public string Text { get; set; }

        public override string GetText()
        {
            return Text;
        }
    }
}
