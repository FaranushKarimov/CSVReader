// <copyright file="Field.cs" company="PlaceholderCompany">
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
    /// Класс репрезентация поля.
    /// </summary>
    [Table(Name = "Fields")]
    public class Field
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Field"/> class.
        /// </summary>
        public Field()
        {
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int FieldId { get; set; }

        /// <summary>
        /// Gets or sets field Title.
        /// </summary>
        [Column]
        public string FieldTitle { get; set; }

        /// <summary>
        /// Gets or sets field Type.
        /// </summary>
        [Column]
        public Type? Type { get; set; }

        /// <summary>
        /// Gets or sets question.
        /// </summary>
        [Column]
        public string Question { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether that field Required.
        /// </summary>
        [Column]
        public bool Required { get; set; }

        /// <summary>
        /// Gets or sets Form_FormId.
        /// </summary>
        [Column]
        public int Form_FormId { get; set; }
    }
}