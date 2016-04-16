using Qiniu.RS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RShop.ManagePlatform.Controllers
{
    public class QiNiuController : AdminController
    {
        // GET: QiNiu
        static QiNiuController()
        {
            Qiniu.Conf.Config.Init();
        }
        [AllowAnonymous]
        public JsonResult GetToken()
        {
            var policy = new PutPolicy("i4ta");
            string token = policy.Token();
            var jsonToken = new { uptoken = token };
            return Json(jsonToken, JsonRequestBehavior.AllowGet);
        }
    }
}