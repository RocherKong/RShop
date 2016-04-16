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
    /// 验证Token
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class AuthTokenAttribute : AuthorizationFilterAttribute
    {
        /// <summary>
        /// Token Key 前缀
        /// </summary>
        public String PrefixTokenKey { get; set; }
        public ILogger Logger { get { return LogManager.GetCurrentClassLogger(); } }
        CacheProvider cacheProvider = CacheProvider.LoadInstance<CacheProvider>("RedisCacheProvider");
        MQProvider mqProvier = MQProvider.LoadInstance<MQProvider>("RabbitMQProvider");
        /// <summary>
        /// 验证Token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool CheckToken(String token)
        {
            string cacheKey = String.Format("{0}{1}", PrefixTokenKey, token);
            return cacheProvider.Exisit(cacheKey);
        }

        protected virtual void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            if (actionContext == null)
            {
                throw new ArgumentNullException("actionContext");
            }
            throw new RShopException("00004", "Token 验证失效!");
        }
        protected virtual bool IsAuthorized(HttpActionContext actionContext)
        {
            KeyValuePair<String, String> obj_Token = actionContext.Request.GetQueryNameValuePairs().FirstOrDefault(m => m.Key.ToLower() == "token");
            String serviceApi = actionContext.Request.RequestUri.ToString();
            String requestContent = actionContext.Request.Content.ReadAsStringAsync().Result;
            if (String.IsNullOrEmpty(obj_Token.Key))
            {
                throw new RShopException("00005", "Token 不能为空!");
            }

            bool isSuccess = CheckToken(obj_Token.Value);
            InsertLog(obj_Token.Value, serviceApi, requestContent, isSuccess);
            return isSuccess;
        }

        private void InsertLog(string token, string serviceApi, string requestContent, bool isSuccess)
        {

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
            if (!actionContext.ActionDescriptor.GetCustomAttributes<NoneTokenAttribute>().Any<NoneTokenAttribute>())
            {
                return actionContext.ControllerContext.ControllerDescriptor.GetCustomAttributes<NoneTokenAttribute>().Any<NoneTokenAttribute>();
            }
            return true;
        }

    }
}
