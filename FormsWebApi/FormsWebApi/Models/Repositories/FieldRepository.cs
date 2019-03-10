// <copyright file="FieldRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Класс для работы с таблицей Field.
    /// </summary>
    public class FieldRepository : IGenericRepository<Field>
    {
        private DataContext db;

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldRepository"/> class.
        /// </summary>
        public FieldRepository()
        {
            this.db = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldRepository"/> class.
        /// </summary>
        /// <param name="dataContext">DB context.</param>
        public FieldRepository(DataContext dataContext)
        {
            this.db = dataContext;
        }

        /// <inheritdoc/>
        public void Create(Field item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Field GetById(int id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void Remove(Field item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void Update(Field item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Getting fields by Id form..
        /// </summary>
        /// <param name="id">Form id.</param>
        /// <returns>List of fields.</returns>
        public List<Field> GetFields(int id)
        {
            return this.db.GetTable<Field>().Where(f => f.Form_FormId == id).ToList();
        }
    }
}