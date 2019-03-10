// <copyright file="AuditInfo.cs" company="PlaceholderCompany">
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
    /// Класс репрезентация данных о запросах к БД.
    /// </summary>
    [Table(Name = "AuditInfoes")]
    public class AuditInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditInfo"/> class.
        /// </summary>
        public AuditInfo()
        {
        }

        /// <summary>
        /// Gets or sets AuditInfoId.
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int AuditInfoId { get; set; }

        /// <summary>
        /// Gets or sets Time.
        /// </summary>
        [Column]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets FormId.
        /// </summary>
        [Column]
        public int FormId { get; set; }

        /// <summary>
        /// Gets or sets ClientIp.
        /// </summary>
        [Column]
        public string ClientIp { get; set; }
    }
}