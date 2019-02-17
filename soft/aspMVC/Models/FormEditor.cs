// <copyright file="FormEditor.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace aspMVC.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Representation class of forms.
    /// </summary>
    public class FormEditor
    {
        /// <summary>
        /// Gets or sets form title.
        /// </summary>
        public string FormHead { get; set; }

        /// <summary>
        /// Gets or sets form description.
        /// </summary>
        public string FormDescription { get; set; }

        /// <summary>
        /// Gets or sets list of fields.
        /// </summary>
        public List<Field> Fields { get; set; }
    }
}