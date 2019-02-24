// <copyright file="AdminController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;
    using AspFormEditor.Models;

    /// <summary>
    /// Controller for processing admin requests.
    /// </summary>
    public class AdminController : Controller
    {
        /// <summary>
        /// Main page admin panel.
        /// </summary>
        /// <returns>Redirects to the form creation page.</returns>
        [HttpGet]
        public ActionResult Index()
        {
            return this.RedirectToAction("Create");
        }

        /// <summary>
        /// Page create a new form.
        /// </summary>
        /// <returns>Gives the editor page.</returns>
        [HttpGet]
        public ActionResult Create()
        {
            return this.View();
        }

        /// <summary>
        /// Saving a new form
        /// </summary>
        /// <param name="form">Retained form.</param>
        /// <returns>Redirects to the form edit page.</returns>
        [HttpPost]
        public ActionResult Create(Form form)
        {
            if (this.ModelState.IsValid)
            {
                this.SaveForm(form);
                this.TempData["Message"] = "Форма успешно сохранена.";
                return this.RedirectToAction("Edit", new { @id = form.FormId });
            }

            return this.View(form);
        }

        /// <summary>
        /// The page for editing an existing form.
        /// </summary>
        /// <param name="id">Id editable form.</param>
        /// <returns>Gives the editor page.</returns>
        [HttpGet]
        public ActionResult Edit(int id = -1)
        {
            var list = (List<Form>)this.Session["Database"];
            var form = list.Find(item => item.FormId == id);

            if (form == null)
            {
                return this.Redirect("/Error/NotFound");
            }

            return this.View(form);
        }

        /// <summary>
        /// Saving editable form
        /// </summary>
        /// <param name="form">Retained form.</param>
        /// <returns>Redirects to the form edit page.</returns>
        [HttpPost]
        public ActionResult Edit(Form form)
        {
            if (this.ModelState.IsValid)
            {
                this.SaveForm(form);
                this.TempData["Message"] = "Форма успешно сохранена.";
                return this.RedirectToAction("Edit", new { @id = form.FormId });
            }

            return this.View(form);
        }

        /// <summary>
        /// Block generation via partial view.
        /// </summary>
        /// <returns>Returns a block of fields.</returns>
        [HttpGet]
        public ActionResult GenerateField()
        {
            return this.PartialView("PartialViews/_FieldBlock", new Field());
        }

        /// <summary>
        /// Initializer for creating a database in session.
        /// </summary>
        /// <param name="requestContext">HTTP request information.</param>
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            if (this.Session["Database"] == null)
            {
                this.Session["Database"] = new List<Form>();
            }
        }

        /// <summary>
        /// Saving the form in session
        /// </summary>
        /// <param name="form">Retained form.</param>
        private void SaveForm(Form form)
        {
            if (this.ModelState.IsValid)
            {
                var list = (List<Form>)this.Session["Database"];

                if (form.FormId == -1)
                {
                    form.FormId = list.Count;
                    list.Add(form);
                }
                else
                {
                    var oldForm = list.Find(item => item.FormId == form.FormId);
                    list.Remove(oldForm);
                    list.Add(form);
                }

                this.Session["Database"] = list;
            }
        }
    }
}