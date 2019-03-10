// <copyright file="Form.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq.Mapping;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Класс репрезентация формы.
    /// </summary>
    [Table(Name = "Forms")]
    public class Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form"/> class.
        /// </summary>
        public Form()
        {
        }

        /// <summary>
        /// Gets or sets form Id.
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int FormId { get; set; }

        /// <summary>
        /// Gets or sets form Title.
        /// </summary>
        [Column]
        public string FormTitle { get; set; }

        /// <summary>
        /// Gets or sets form Description.
        /// </summary>
        [Column]
        public string Description { get; set; }
    }
}