// <copyright file="FormRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor.Models.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Entity Repository <see cref="Form"/>.
    /// </summary>
    public class FormRepository : IGenericRepository<Form>
    {
        /// <summary>
        /// Creation data context of database
        /// </summary>
        private DataContext db;

        /// <summary>
        /// Creation Field Repository
        /// </summary>
        private FieldRepository fieldRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRepository"/> class.
        /// </summary>
        public FormRepository()
        {
            this.db = new DataContext();
            this.fieldRepository = new FieldRepository();
        }

        /// <summary>
        /// Adding a new form.
        /// </summary>
        /// <param name="item">Add form.</param>
        public void Create(Form item)
        {
            this.db.Forms.Add(item);
            this.db.SaveChanges();
        }

        /// <summary>
        /// Receiving the form of the transmitted Id.
        /// </summary>
        /// <param name="id">Form Id</param>
        /// <returns>Form with transmitted Id.</returns>
        public Form GetById(int id)
        {
            return this.db.Forms.SingleOrDefault(item => item.FormId == id);
        }

        /// <summary>
        /// Delete the submitted form.
        /// </summary>
        /// <param name="item">Removable form.</param>
        public void Remove(Form item)
        {
            this.db.Forms.Remove(item);
            this.db.SaveChanges();
        }

        /// <summary>
        /// Update submitted form.
        /// </summary>
        /// <param name="form">Updated form.</param>
        public void Update(Form form)
        {
            var item = this.GetById(form.FormId);
            if (item != null)
            {
                item.FormTitle = form.FormTitle;
                item.Description = form.Description;

                for (int i = 0; i < item.Fields.Count; i++)
                {
                    if (form.Fields.FirstOrDefault(f => f.FieldId == item.Fields[i].FieldId) == null)
                    {
                        this.db.Fields.Remove(item.Fields[i]);
                    }
                }

                for (int i = 0; i < form.Fields.Count; i++)
                {
                    if (form.Fields[i].FieldId == 0)
                    {
                        item.Fields.Add(form.Fields[i]);
                    }
                    else
                    {
                        this.fieldRepository.Update(form.Fields[i]);
                    }
                }

                this.db.Entry(item).State = System.Data.Entity.EntityState.Modified;

                this.db.SaveChanges();
            }
        }
    }
}