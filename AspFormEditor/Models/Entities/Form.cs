// <copyright file="Form.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// Class representation of a form.
    /// </summary>
    public class Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form"/> class.
        /// </summary>
        public Form()
        {
            this.Fields = new List<Field>();
        }

        /// <summary>
        /// Gets or sets form Id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [HiddenInput(DisplayValue = false)]
        public int FormId { get; set; }

        /// <summary>
        /// Gets or sets form Title.
        /// </summary>
        [Required(ErrorMessage = "Заголовок формы должен быть задан")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Заголовок формы должен иметь длину от 4 до 20 символов")]
        public string FormTitle { get; set; }

        /// <summary>
        /// Gets or sets form Description.
        /// </summary>
        [DataType(DataType.MultilineText)]
        [StringLength(20, ErrorMessage = "Описание формы должно иметь длинну не более 20 символов")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets list of Fields.
        /// </summary>
        public virtual IList<Field> Fields { get; set; }
    }
}