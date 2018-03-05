using System;

namespace Domain
{
    /// <summary>
    /// Ítem RSS.
    /// </summary>
    public class RssItem
    {

        /// <summary>
        /// Id unico del item
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id del banner al que pertenece
        /// </summary>
        public int IdRssSource { get; set; }

        /// <summary>
        /// Título del ítem.
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// Descripción acerca del ítem.
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// URL del ítem.
        /// </summary>
        public String Url { get; set; }

        /// <summary>
        /// Fecha de publicación.
        /// </summary>
        public DateTime? PublishingDate { get; set; }

    }
}
