// <copyright file="Type.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Type of form field.
    /// </summary>
    public enum Type
    {
        /// <summary>
        /// Type: text - string.
        /// </summary>
        [Display(Name = "Текст - строка")]
        Text = 1,

        /// <summary>
        /// Type: text - paragraph.
        /// </summary>
        [Display(Name = "Текст - абзац")]
        Paragraph = 2,

        /// <summary>
        /// Type: one from the list.
        /// </summary>
        [Display(Name = "Один из списка")]
        ListOne = 3,

        /// <summary>
        /// Type: a few from the list.
        /// </summary>
        [Display(Name = "Несколько из списка")]
        ListMany = 4,

        /// <summary>
        /// Type: drop-down list.
        /// </summary>
        [Display(Name = "Раскрывающийся список")]
        Dropdown = 5
    }
}