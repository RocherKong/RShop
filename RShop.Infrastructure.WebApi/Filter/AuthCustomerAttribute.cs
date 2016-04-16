using NLog;
using RShop.Infrastructure.Cache.Interface;
using RShop.Infrastructure.Exception;
using RShop.Infrastructure.MQ.Interface;
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
    /// 验证SessionId
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class AuthCustomerAttribute : AuthorizationFilterAttribute
    {
        /// <summary>
        /// Session Key 前缀
        /// </summary>
        public String PrefixSessionKey { get; set; }
        public ILogger Logger { get { return LogManager.GetCurrentClassLogger(); } }
        CacheProvider cacheProvider = CacheProvider.LoadInstance<CacheProvider>("RedisCacheProvider");
        MQProvider mqProvier = MQProvider.LoadInstance<MQProvider>("RabbitMQProvider");
        /// <summary>
        /// 验证SessionId
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool CheckSessionId(String sessionId)
        {
            string cacheKey = String.Format("{0}{1}", PrefixSessionKey, sessionId);
            return cacheProvider.Exisit(cacheKey);
        }

        protected virtual void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            if (actionContext == null)
            {
                throw new ArgumentNullException("actionContext");
            }
            throw new RShopException("20004", "SessionId 验证失效!");
        }
        protected virtual bool IsAuthorized(HttpActionContext actionContext)
        {
            String sessionId = GetSessionId(actionContext);
            String serviceApi = actionContext.Request.RequestUri.ToString();
            String requestContent = actionContext.Request.Content.ReadAsStringAsync().Result;

            bool isSuccess = CheckSessionId(sessionId);

            return isSuccess;
        }

        private String GetSessionId(HttpActionContext actionContext)
        {
            KeyValuePair<string, string> obj_sessionId = actionContext.Request.GetQueryNameValuePairs().FirstOrDefault(m => m.Key.ToLower() == "sid");

            if (String.IsNullOrEmpty(obj_sessionId.Key))
            {
                throw new RShopException("20005", "SessionId 不能为空!");
            }
            return obj_sessionId.Value;
        }

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext == null)
            {
                throw new ArgumentNullException("actionContext");
            }
            if (!SkipAuthorization(actionContext) && !IsAuthorized(actionContext))
            {
                HandleUnauthorizedRequest(actionContext);
            }
        }

        private static bool SkipAuthorization(HttpActionContext actionContext)
        {
            if (!actionContext.ActionDescriptor.GetCustomAttributes<NoneCustomerAttribute>().Any<NoneCustomerAttribute>())
            {
                return actionContext.ControllerContext.ControllerDescriptor.GetCustomAttributes<NoneCustomerAttribute>().Any<NoneCustomerAttribute>();
            }
            return true;
        }

    }
}
