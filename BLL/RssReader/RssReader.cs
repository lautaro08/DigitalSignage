using System;
using System.Collections.Generic;
using Domain;
using DTO;

namespace BLL
{
    /// <summary>
    /// Implementación de base del lector de RSS.
    /// </summary>
    public abstract class RssReader : IRssReader
    {

        public IEnumerable<RssItemDTO> Read(String pUrl)
        {
            if (String.IsNullOrWhiteSpace(pUrl))
            {
                throw new ArgumentException("pUrl");
            }

            return this.Read(new Uri(pUrl));
        }

        public abstract IEnumerable<RssItemDTO> Read(Uri pUrl);

    }
}
