// <copyright file="DataContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// DataContext class.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class.
        /// </summary>
        public DataContext()
            : base("Datastore")
        {
            Database.SetInitializer<DataContext>(new DbInitializer());
        }

        /// <summary>
        /// Gets or sets Fields.
        /// </summary>
        public DbSet<Field> Fields { get; set; }

        /// <summary>
        /// Gets or sets Forms.
        /// </summary>
        public DbSet<Form> Forms { get; set; }
    }
}