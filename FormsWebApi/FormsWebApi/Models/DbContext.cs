// <copyright file="DbContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.Linq;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// DbContext class.
    /// </summary>
    public class DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DbContext"/> class.
        /// </summary>
        public DbContext()
        {
            DataContext db = new DataContext(ConfigurationManager.ConnectionStrings["Datastore"].ConnectionString);

            this.AuditInfo = new AuditInfoRepository(db);
            this.Field = new FieldRepository(db);
            this.Form = new FormRepository(db);
        }

        /// <summary>
        /// Gets or sets AuditInfo.
        /// </summary>
        public AuditInfoRepository AuditInfo { get; set; }

        /// <summary>
        /// Gets or sets Field.
        /// </summary>
        public FieldRepository Field { get; set; }

        /// <summary>
        /// Gets or sets Form.
        /// </summary>
        public FormRepository Form { get; set; }
    }
}