// <copyright file="ValuesControllerTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi.Tests.Controllers
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Web.Http;
    using FormsWebApi;
    using FormsWebApi.Controllers;
    using FormsWebApi.Models;

    /// <summary>
    /// Values Controller Test
    /// </summary>
    [TestClass]
    public class ValuesControllerTest
    {
        /// <summary>
        /// Get Integer Id
        /// </summary>
        [TestMethod] ////Нужно заменить работу с базой на mock-object
        public void GetById()
        {
            //// Упорядочение
            ////ValuesController controller = new ValuesController();

            //// Действие
            ////FormJson result = controller.Get(1);

            //// Утверждение
            ////Assert.AreEqual(1, result.FormId);
        }
    }
}
