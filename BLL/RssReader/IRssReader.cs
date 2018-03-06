using System;
using System.Collections.Generic;
using Domain;
using DTO;

namespace BLL
{
    /// <summary>
    /// Lector de Really Simple Syndication (RSS).
    /// </summary>
    public interface IRssReader
    {

        /// <summary>
        /// Obtiene los ítems de un feed RSS, donde <paramref name="pUrl"/> es una instancia de <see cref="System.Uri"/>.
        /// </summary>
        /// <param name="pUrl">URL del feed.</param>
        /// <returns>Ítems.</returns>
        /// <exception cref="System.ArgumentNullException">Si no se proporciona una URL.</exception>
        IEnumerable<RssItemDTO> Read(Uri pUrl);

        /// <summary>
        /// Obtiene los ítems de un feed RSS, donde <paramref name="pUrl"/> es una instancia de <see cref="System.String"/>.
        /// </summary>
        /// <param name="pUrl">URL del feed.</param>
        /// <returns>Ítems.</returns>
        /// <exception cref="System.ArgumentNullException">Si no se proporciona una URL.</exception>
        /// <exception cref="System.UriFormatException">Si la URL no es válida.</exception>
        IEnumerable<RssItemDTO> Read(String pUrl);

    }
}
