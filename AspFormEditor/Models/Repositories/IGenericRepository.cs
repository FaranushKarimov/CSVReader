// <copyright file="IGenericRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor.Models.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// IGenericRepository interface.
    /// </summary>
    /// <typeparam name="TEntity">Create interface</typeparam>
    public interface IGenericRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Create method.
        /// </summary>
        /// <param name="item">Create item</param>
        void Create(TEntity item);

        /// <summary>
        /// GetById method.
        /// </summary>
        /// <param name="id">integer id</param>
        /// <returns>returns id integer</returns>
        TEntity GetById(int id);

        /// <summary>
        /// Update method.
        /// </summary>
        /// <param name="item">Update item</param>
        void Update(TEntity item);

        /// <summary>
        /// Remove method.
        /// </summary>
        /// <param name="item">Remove item</param>
        void Remove(TEntity item);
    }
}
