// <copyright file="FormRepository.cs" company="PlaceholderCompany">
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
    /// Class for working with the form table.
    /// </summary>
    public class FormRepository : IGenericRepository<Form>
    {
        private DataContext db;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRepository"/> class.
        /// </summary>
        public FormRepository()
        {
            this.db = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRepository"/> class.
        /// </summary>
        /// <param name="dataContext">DB context.</param>
        public FormRepository(DataContext dataContext)
        {
            this.db = dataContext;
        }

        /// <inheritdoc/>
        public void Create(Form item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Form GetById(int id)
        {
            return this.db.GetTable<Form>().Where(f => f.FormId == id).FirstOrDefault();
        }

        /// <inheritdoc/>
        public void Remove(Form item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void Update(Form item)
        {
            throw new NotImplementedException();
        }
    }
}