// <copyright file="RouteConfig.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace aspMVC
{
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// RouteConfig class.
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// RegisterRoutes method.
        /// </summary>
        /// <param name="routes">Collection of routes.</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(name: "Default", url: "{controller}/{action}/{id}", defaults: new { controller = "Home", action = "FrontendForm", id = UrlParameter.Optional });
        }
    }
}
