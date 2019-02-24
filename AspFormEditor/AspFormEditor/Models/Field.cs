// <copyright file="Field.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// Class representation of the block.
    /// </summary>
    [Serializable]
    public class Field
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Field"/> class.
        /// </summary>
        public Field()
        {
        }

        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public int FieldId { get; set; }

        /// <summary>
        /// Gets or sets field title.
        /// </summary>
        [Required(ErrorMessage = "Заголовок блока должен быть задан")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Заголовок блока должен иметь длину от 4 до 20 символов")]
        public string FieldTitle { get; set; }

        /// <summary>
        /// Gets or sets field type.
        /// </summary>
        [Required(ErrorMessage = "Тип вопроса должен быть задан")]
        public Type? Type { get; set; }

        /// <summary>
        /// Gets or sets question.
        /// </summary>
        [StringLength(150, ErrorMessage = "Вопрос должен иметь длину не более 150 символов")]
        public string Question { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether that field required.
        /// </summary>
        public bool Required { get; set; }
    }
}