// <copyright file="FilterConfig.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi
{
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// FilterConfig class.
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Register Global Filters method.
        /// </summary>
        /// <param name="filters">Add Filters.</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
