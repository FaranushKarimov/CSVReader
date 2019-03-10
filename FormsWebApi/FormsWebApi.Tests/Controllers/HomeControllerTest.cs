// <copyright file="HomeControllerTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi.Tests.Controllers
{
    using System.Web.Mvc;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using FormsWebApi;
    using FormsWebApi.Controllers;

    /// <summary>
    /// Home Controller Test
    /// </summary>
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //// Упорядочение
            HomeController controller = new HomeController();

            //// Действие
            ViewResult result = controller.Index() as ViewResult;

            //// Утверждение
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);

        }
    }
}
