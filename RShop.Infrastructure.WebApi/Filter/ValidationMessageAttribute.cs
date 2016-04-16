using NLog;
using RShop.Infrastructure.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace RShop.Infrastructure.WebApi.Filter
{
    /// <summary>
    /// 请求参数验证，统一处理筛选器
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class ValidationMessageAttribute : ActionFilterAttribute
    {
        #region Properties

        /// <summary>
        /// 日志系统
        /// </summary>
        protected Logger Logger { get { return LogManager.GetCurrentClassLogger(); } }
        #endregion
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
#if Release

            if (actionContext.ActionArguments.Any(v => v.Value == null))
            {
                CreateErrorMessage(actionContext, "请求参数不能为空！");
            }
#endif

            if (!actionContext.ModelState.IsValid)
            {
                CreateErrorMessage(actionContext, actionContext.ModelState.Values.First().Errors[0].ErrorMessage);
            }
            base.OnActionExecuting(actionContext);
        }

        private void CreateErrorMessage(HttpActionContext actionContext, String errorMessage)
        {
            ResponseMessage resp = new ResponseMessage
            {
                IsSuccess = false,
                ErrorCode = "00006",
                Message = errorMessage
            };
            actionContext.Response = actionContext.Request.CreateResponse<ResponseMessage>(resp);
        }
    }
}
