// <copyright file="ErrorController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// Controller for error handling.
    /// </summary>
    public class ErrorController : Controller
    {
        /// <summary>
        /// Page 404.
        /// </summary>
        /// <returns>Gives 404 error page.</returns>
        public ActionResult NotFound()
        {
            this.Response.StatusCode = 404;
            return this.View();
        }
    }
}