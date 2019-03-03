// <copyright file="FieldRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor.Models.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Entity Repository <see cref="Field"/>.
    /// </summary>
    public class FieldRepository : IGenericRepository<Field>
    {
        /// <summary>
        /// Creation data context of database
        /// </summary>
        private DataContext db;

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldRepository"/> class.
        /// </summary>
        public FieldRepository()
        {
            this.db = new DataContext();
        }

        /// <summary>
        /// Adding a new field.
        /// </summary>
        /// <param name="item">The field to add.</param>
        public void Create(Field item)
        {
            this.db.Fields.Add(item);
            this.db.SaveChanges();
        }

        /// <summary>
        /// Receiving a field by the transmitted Id.
        /// </summary>
        /// <param name="id">The received field id.</param>
        /// <returns>Id transmitted field.</returns>
        public Field GetById(int id)
        {
            return this.db.Fields.SingleOrDefault(item => item.FieldId == id);
        }

        /// <summary>
        /// Delete transferred field.
        /// </summary>
        /// <param name="item">Field to delete.</param>
        public void Remove(Field item)
        {
            this.db.Fields.Remove(item);
            this.db.SaveChanges();
        }

        /// <summary>
        /// Update transmitted field.
        /// </summary>
        /// <param name="field">Updateable field.</param>
        public void Update(Field field)
        {
            var item = this.GetById(field.FieldId);
            if (item != null)
            {
                item.FieldTitle = field.FieldTitle;
                item.Type = field.Type;
                item.Question = field.Question;
                item.Required = field.Required;

                this.db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            }

            this.db.SaveChanges();
        }
    }
}