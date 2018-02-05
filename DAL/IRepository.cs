using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{   

    /// <summary>
    /// Interfaz para repositorio generico
    /// </summary>
    /// <typeparam name="TEntity">Clase de la entidad que maneja el repositorio</typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// añade una entidad al repositorio
        /// </summary>
        /// <param name="pEntity">entidad a agregar</param>
        void Add(TEntity pEntity);

        /// <summary>
        /// Elimina una entidad del repositorio
        /// </summary>
        /// <param name="pEntity">entidad a eliminar</param>
        void Remove(TEntity pEntity);

        /// <summary>
        /// obtiene una entidad por su id
        /// </summary>
        /// <param name="pId">id de la entidad que se quiere obtener</param>
        /// <returns>la entidad con el id especificado</returns>
        TEntity Get(int pId);

        /// <summary>
        /// obtiene todas las entidades almacenadas en el repositorio
        /// </summary>
        /// <returns>una coleccion de entidades</returns>
        IEnumerable<TEntity> GetAll();
        
    }
}
