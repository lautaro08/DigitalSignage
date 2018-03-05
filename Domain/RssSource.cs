using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    /// <summary>
    /// implementacion de una fuente de banner RSS
    /// </summary>
    public class RssSource : BannerSource
    {

        /// <summary>
        /// url de donde se obtienen los item RSS
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Items que se almacenan para dar soporte ofline a la fuente RSS
        /// </summary>
        public virtual IList<RssItem> RssItems { get; set; }

        /// <summary>
        /// transforma las lista de items RSS en texto
        /// </summary>
        /// <returns>cadena de texto</returns>
        public override string GetText()
        {
            string text = "";

            using (var enumerator = RssItems.GetEnumerator())
            {

                while (enumerator.MoveNext())
                {

                    var current = enumerator.Current;
                    text += current.Title + " : " + current.Description + " | ";

                }

            }

            return text;
        }
    }
}
