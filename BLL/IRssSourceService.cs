using DTO;
using Domain;
using DAL;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;

namespace BLL
{

    /// <summary>
    /// Interface para el servicio de fuentes rss
    /// </summary>
    public interface IRssSourceService
    {

        /// <summary>
        /// Crea una fuente RSS
        /// </summary>
        /// <param name="pRssSourceDTO">fuente RSS que se quiere crear</param>
        void Create(RssSourceDTO pRssSourceDTO);

        /// <summary>
        /// Eliminar una fuente RSS
        /// </summary>
        /// <param name="pRssSourceDTO">fuente RSS que se desea eliminar</param>
        void Remove(RssSourceDTO pRssSourceDTO);

        /// <summary>
        /// Actualiza una fuente RSS
        /// </summary>
        /// <param name="pRssSourceDTO">fuente RSS que se desea actualizar</param>
        void Update(RssSourceDTO pRssSourceDTO);

        /// <summary>
        /// Obtiene una fuente RSS por su id
        /// </summary>
        /// <param name="pId">id de la fuente RSS que se quiere obtener</param>
        /// <returns></returns>
        RssSourceDTO Get(int pId);


        /// <summary>
        /// Obtiene todas las fuente RSSs
        /// </summary>
        IEnumerable<RssSourceDTO> GetAll();

    }
}
