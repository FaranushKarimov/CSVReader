// <copyright file="AdminController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;
    using AspFormEditor.Models;
    using AspFormEditor.Models.Repositories;

    /// <summary>
    /// Controller for reverse requests for admin panel requests.
    /// </summary>
    public class AdminController : Controller
    {
        /// <summary>
        /// Private repository form
        /// </summary>
        private FormRepository formRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminController"/> class.
        /// </summary>
        public AdminController()
        {
            this.formRepository = new FormRepository();
        }

        /// <summary>
        /// Main page admin panel.
        /// </summary>
        /// <returns>Redirect to form creation page.</returns>
        [HttpGet]
        public ActionResult Index()
        {
            return this.RedirectToAction("Create");
        }

        /// <summary>
        /// Page create a new form.
        /// </summary>
        /// <returns>Page editor.</returns>
        [HttpGet]
        public ActionResult Create()
        {
            return this.View("Editor");
        }

        /// <summary>
        /// The page for editing an existing form.
        /// </summary>
        /// <param name="id">Id editable form.</param>
        /// <returns>Page editor.</returns>
        [HttpGet]
        public ActionResult Edit(int id = -1)
        {
            var form = this.formRepository.GetById(id);

            if (form == null)
            {
                return this.RedirectToAction("NotFound", "Error");
            }
            else
            {
                return this.View("Editor", form);
            }
        }

        /// <summary>
        /// Save editable form.
        /// </summary>
        /// <param name="form">Retained form.</param>
        /// <returns>Redirect to form edit page.</returns>
        [HttpPost]
        public ActionResult SaveForm(Form form)
        {
            if (this.ModelState.IsValid)
            {
                if (form.FormId == 0)
                {
                    this.formRepository.Create(form);
                }
                else
                {
                    this.formRepository.Update(form);
                }

                this.TempData["Message"] = "Форма успешно сохранена.";
                return this.RedirectToAction("Edit", new { @id = form.FormId });
            }

            return this.View("Editor", form);
        }
    }
}