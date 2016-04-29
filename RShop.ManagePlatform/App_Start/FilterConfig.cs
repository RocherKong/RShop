using RShop.Infrastructure.Web.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RShop.ManagePlatform
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AuthAccountAttribute { Roles = "Admin", LogOnUrl = "/Account/Logon" });
            filters.Add(new ExceptionAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}