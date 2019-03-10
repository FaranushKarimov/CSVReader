// <copyright file="Type.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Тип поля формы.
    /// </summary>
    public enum Type
    {
        /// <summary>
        /// Тип: текст - строка.
        /// </summary>
        Text = 1,

        /// <summary>
        /// Тип: текст - абзац.
        /// </summary>
        Paragraph = 2,

        /// <summary>
        /// Тип: один из списка.
        /// </summary>
        ListOne = 3,

        /// <summary>
        /// Тип: несколько из списка.
        /// </summary>
        ListMany = 4,

        /// <summary>
        /// Тип: раскрывающийся список.
        /// </summary>
        Dropdown = 5
    }
}