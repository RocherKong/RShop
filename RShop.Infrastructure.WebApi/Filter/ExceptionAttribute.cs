using NLog;
using RShop.Infrastructure.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace RShop.Infrastructure.WebApi.Filter
{
    public class ExceptionAttribute : ExceptionFilterAttribute
    {
        #region Properties

        /// <summary>
        /// 日志系统
        /// </summary>
        protected Logger Logger { get { return LogManager.GetCurrentClassLogger(); } }

        #endregion
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            ResponseMessage resp = new ResponseMessage
            {
                IsSuccess = false,
                ErrorCode = "00001",
                Message = actionExecutedContext.Exception.Message
            };
            if (actionExecutedContext.Exception is RShopException)
            {
                RShopException meEx = actionExecutedContext.Exception as RShopException;
                resp.ErrorCode = String.IsNullOrEmpty(meEx.ErrorCode) ? "00002" : meEx.ErrorCode;
                Logger.Warn(actionExecutedContext.Exception);
            }
            else
            {
                Logger.Error(actionExecutedContext.Exception);
            }

            actionExecutedContext.Response = actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse<ResponseMessage>(resp);
            base.OnException(actionExecutedContext);
        }

        private class ResponseMessage
        {
            public string ErrorCode { get; set; }
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
        }
    }
}
