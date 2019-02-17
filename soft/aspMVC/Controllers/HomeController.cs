// <copyright file="HomeController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspMVC.Controllers
{
    using System.Web.Mvc;
    using aspMVC.Models;

    /// <summary>
    /// Controller for processing requests.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// The page for editing an existing form.
        /// </summary>
        /// <returns>Gives the editor page.</returns>
        [HttpGet]
        public ActionResult FrontendForm()
        {
            FormEditor formEditor = new FormEditor();
  
            return this.View(formEditor);
        }

        /// <summary>
        /// Saving editable form
        /// </summary>
        /// <param name="formEditor">Saving form</param>
        /// <returns>return Success after saving</returns>
        [HttpPost]
        public string FrontendForm(FormEditor formEditor)
        {
            return "Success";
        }
    }
}