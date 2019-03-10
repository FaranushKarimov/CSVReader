// <copyright file="FormJson.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Class representation of the form in json format.
    /// </summary>
    public class FormJson
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormJson"/> class.
        /// </summary>
        public FormJson()
        {
            this.Fields = new List<FieldJson>();
        }

        /// <summary>
        /// Gets or sets form Id.
        /// </summary>
        public int FormId { get; set; }

        /// <summary>
        /// Gets or sets form Title.
        /// </summary>
        public string FormTitle { get; set; }

        /// <summary>
        /// Gets or sets form Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets list of Fields.
        /// </summary>
        public virtual IList<FieldJson> Fields { get; set; }
    }
}