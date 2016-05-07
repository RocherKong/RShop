using RShop.Infrastructure.Const;
using RShop.TradingCenter.Entity;
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
        public T_Administrator Admin
        {
            get
            {
                return Session[SessionKey.AdminKey] as T_Administrator;
            }
            set
            {
                Session[SessionKey.AdminKey] = value;
            }
        }

    }

    public class Administrator
    {
        public long Id { get; set; }
    }
    

}