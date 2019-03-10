// <copyright file="WebApiConfig.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    /// <summary>
    /// Web Api Config class.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Register method.
        /// </summary>
        /// <param name="config">Register Config.</param>
        public static void Register(HttpConfiguration config)
        {
            // Конфигурация и службы веб-API

            // Маршруты веб-API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            // Переход с xml на json
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
