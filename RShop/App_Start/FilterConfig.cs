using RShop.Infrastructure.Web.Filter;
using System.Web;
using System.Web.Mvc;

namespace RShop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
          //  filters.Add(new HandleErrorAttribute());
           // filters.Add(new ExceptionAttribute());
       //     filters.Add(new AuthAccountAttribute { Roles = "Admin", LogOnUrl = "/Account/Logon" });
        }
    }
}
