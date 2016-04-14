using RShop.Infrastructure.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RShop.Infrastructure.Web.Filter
{
    /// <summary>
    /// 登录授权验证
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class AuthAccountAttribute : FilterAttribute, IAuthorizationFilter
    {
        public String LogOnUrl { get; set; }
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            bool inherit = true;
            if (!filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), inherit)&&!filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute),true))
            {
                if (!IsAuthenticated())
                {
                    if (filterContext.HttpContext.Request.IsAjaxRequest())
                    {
                        ResponseMessage respMsg = new ResponseMessage
                        {
                            IsSuccess = false,
                            ErrorCode = "00003",
                            Message = "请先登录！"
                        };
                        JsonResult result = new JsonResult();
                        result.Data = respMsg;
                        result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
                        filterContext.Result = result;
                    }
                }
            }
        }

        /// <summary>
        /// 验证登录状态
        /// </summary>
        /// <returns></returns>
        private bool IsAuthenticated()
        {
            if (String.IsNullOrEmpty(Roles))
            {
                return false;
            }
            bool isSuccess = false;
            String[] roles = Roles.Split(new String[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string role in roles)
            {
                if (HttpContext.Current.Session[role] != null)
                {
                    isSuccess = true;
                }
            }
            return isSuccess;
        }

        public String Roles { get; set; }
    }
}

