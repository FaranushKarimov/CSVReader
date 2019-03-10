// <copyright file="FieldJson.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Класс репрезентация поля в json формате.
    /// </summary>
    public class FieldJson
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldJson"/> class.
        /// </summary>
        public FieldJson()
        {
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int FieldId { get; set; }

        /// <summary>
        /// Gets or sets field Title.
        /// </summary>
        public string FieldTitle { get; set; }

        /// <summary>
        /// Gets or sets field Type.
        /// </summary>
        public Type? Type { get; set; }

        /// <summary>
        /// Gets or sets question.
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether that field Required.
        /// </summary>
        public bool Required { get; set; }
    }
}