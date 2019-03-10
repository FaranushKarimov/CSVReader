// <copyright file="HomeController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    /// <inheritdoc/>
    public class HomeController : Controller
    {
        /// <summary>
        /// Homepage.
        /// </summary>
        /// <returns>Homepage view.</returns>
        public ActionResult Index()
        {
            this.ViewBag.Title = "Home Page";

            return this.View();
        }
    }
}
