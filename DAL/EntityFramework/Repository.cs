﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.EntityFramework
{

    /// <summary>
    /// Implementacion base de un repositio
    /// </summary>
    /// <typeparam name="TEntity">Entidad de dominio la cual se realizará el repositorio</typeparam>
    /// <typeparam name="TDbContext">Contexto de acceso a BBDD</typeparam>
    public abstract class Repository<TEntity, TDbContext> : IRepository<TEntity>
        where TEntity : class
        where TDbContext : DbContext
    {

        /// <summary>
        /// variable de instancia con el contexto
        /// </summary>
        protected readonly TDbContext iDbContext;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="pContext"></param>
        public Repository(TDbContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }

            this.iDbContext = pContext;
        }

        /// <summary>
        /// Agrega la entidad
        /// </summary>
        /// <param name="pEntity">Entidad</param>
        public void Add(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Add(pEntity);
        }


        /// <summary>
        /// Obtiene la entidad por Id
        /// </summary>
        /// <param name="pId">Identificador de la entidad</param>
        /// <returns>Entidad</returns>
        public virtual TEntity Get(int pId)
        {
            return this.iDbContext.Set<TEntity>().Find(pId);
        }

        /// <summary>
        /// Obtiene todas las entidades
        /// </summary>
        /// <returns>Coleccion de entidades</returns>
        public virtual IEnumerable<TEntity> GetAll()
        {
            return this.iDbContext.Set<TEntity>().ToList();
        }

        /// <summary>
        /// Elimina una entidad
        /// </summary>
        /// <param name="pEntity">Entidad</param>
        public void Remove(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Remove(pEntity);
        }
    }
}

