using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RShop.ManagePlatform.Controllers
{
    /// <summary>
    /// 管理员控制器基类
    /// </summary>
    public abstract class AdminController : Controller
    {
        public Administrator Admin { get { return new Administrator { Id = 1 }; } }

    }

    public class Administrator
    {
        public long Id { get; set; }
    }
}