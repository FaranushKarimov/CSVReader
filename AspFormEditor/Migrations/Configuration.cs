// <copyright file="Configuration.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    /// <summary>
    /// Configuration class.
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<AspFormEditor.Models.DataContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration"/> class.
        /// </summary>
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.ContextKey = "AspFormEditor.Models.DataContext";
        }

        /// <summary>
        /// Seed method.
        /// </summary>
        /// <param name="context">Db context.</param>
        protected override void Seed(AspFormEditor.Models.DataContext context)
        {
            // This method will be called after migrating to the latest version.

            // You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
