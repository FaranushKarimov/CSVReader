// <copyright file="Field.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace aspMVC.Models
{
    /// <summary>
    /// Representation class of block.
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        public int FieldId { get; set; }

        /// <summary>
        /// Gets or sets field title.
        /// </summary>
        public string FieldHead { get; set; }

        /// <summary>
        /// Gets or sets field type.
        /// </summary>
        public string FieldType { get; set; } 
        
        /// <summary>
        /// Gets or sets field text area
        /// </summary>
        public string FieldTextArea { get; set; }
        
        /// <summary>
        /// Gets or sets field place holder
        /// </summary>
        public string FieldPlaceholder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether that field required.
        /// </summary>
        public bool FieldRequiredQuestion { get; set; }
    }
}