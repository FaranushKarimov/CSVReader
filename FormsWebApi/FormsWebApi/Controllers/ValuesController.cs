// <copyright file="ValuesController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using FormsWebApi.Models;

    /// <inheritdoc/>
    public class ValuesController : ApiController
    {
        private DbContext db;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesController"/> class.
        /// </summary>
        public ValuesController()
        {
            this.db = new DbContext();
        }

        /// <summary>
        /// Get json form.
        /// </summary>
        /// <param name="id">Form id.</param>
        /// <returns>Json form.</returns>
        public FormJson Get(int id)
        {
            var form = this.db.Form.GetById(id);

            if (form == null)
            {
                return null;
            }

            FormJson formJson = new FormJson() { FormId = form.FormId, FormTitle = form.FormTitle, Description = form.Description };
            foreach (var item in this.db.Field.GetFields(form.FormId))
            {
                formJson.Fields.Add(new FieldJson() { FieldId = item.FieldId, FieldTitle = item.FieldTitle, Type = item.Type, Question = item.Question, Required = item.Required });
            }

            var ip = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList.GetValue(1).ToString();

            this.db.AuditInfo.Create(new AuditInfo() { ClientIp = ip, FormId = id, Time = DateTime.Now });

            return formJson;
        }
    }
}
