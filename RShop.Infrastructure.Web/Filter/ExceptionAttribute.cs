using NLog;
using RShop.Infrastructure.Exception;
using RShop.Infrastructure.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RShop.Infrastructure.Web.Filter
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class ExceptionAttribute : FilterAttribute, IExceptionFilter
    {
        #region Properties

        /// <summary>
        /// 日志系统
        /// </summary>
        protected Logger Logger { get { return LogManager.GetCurrentClassLogger(); } }

        #endregion
        public void OnException(ExceptionContext filterContext)
        {
            ResponseMessage resp = new ResponseMessage
            {
                IsSuccess = false,
                ErrorCode = "00001",
                Message = filterContext.Exception.Message
            };
            if (filterContext.Exception is RShopException)
            {
                RShopException meEx = filterContext.Exception as RShopException;
                resp.ErrorCode = meEx.ErrorCode;
            }
            Logger.Error(filterContext.Exception);
            filterContext.Result = new JsonResult { Data = resp, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

    }
}
