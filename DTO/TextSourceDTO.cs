using System;

namespace DTO
{

    [Serializable]
    /// <summary>
    /// DTO para la clase text source
    /// </summary>
    public class TextSourceDTO : BannerSourceDTO
    {

        /// <summary>
        /// texto de la fuente
        /// </summary>
        public string Text { get; set; }

    }
}
