// <copyright file="IGenericRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// IGenericRepository interface.
    /// </summary>
    /// <typeparam name="TEntity">TEntity</typeparam>
    public interface IGenericRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Create method.
        /// </summary>
        /// <param name="item">TEntity</param>
        void Create(TEntity item);

        /// <summary>
        /// GetById method.
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>TEntity</returns>
        TEntity GetById(int id);

        /// <summary>
        /// Update method.
        /// </summary>
        /// <param name="item">TEntity</param>
        void Update(TEntity item);

        /// <summary>
        /// Remove method.
        /// </summary>
        /// <param name="item">TEntity</param>
        void Remove(TEntity item);
    }
}
