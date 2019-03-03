// <copyright file="FilterConfig.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor
{
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// FilterConfig class.
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// RegisterGlobalFilters method.
        /// </summary>
        /// <param name="filters">All the global filters.</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
