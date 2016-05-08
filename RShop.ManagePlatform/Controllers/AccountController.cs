using RShop.TradingCenter.DomainService;
using RShop.TradingCenter.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RShop.ManagePlatform.Controllers
{
    [AllowAnonymous]
    public class AccountController : AdminController
    {
        private static readonly AdministratorService service = new AdministratorService();
        // GET: Account
        public ActionResult LogOn()
        {

            return View();
        }

        [HttpPost]
        public ActionResult LogOn(string userName, string password)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new Exception("用户名或密码不能为空！");
                }
                T_Administrator admin_Entity = service.LogOn(userName, password);
                if (admin_Entity == null)
                {
                    throw new Exception("用户名或密码错误！");
                }
                Admin = admin_Entity;
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("LogOn");
        }
    }
}