using RShop.Infrastructure.Cache.Interface;
using RShop.Infrastructure.MQ.Interface;
using RShop.Infrastructure.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using NLog;

namespace RShop.Infrastructure.WebApi
{
    public class ApiControllerBase : ApiController
    {
        public Logger Logger { get { return LogManager.GetCurrentClassLogger(); } }

        #region Provider
        //public SMSProvider SMSProvider
        //{
        //    get
        //    {
        //        return BaseProvider.LoadInstance<SMSProvider>("SMSBasicProvider");
        //    }
        //}
        public CacheProvider CacheProvider
        {
            get
            {
                return CacheProvider.LoadInstance<CacheProvider>("RedisCacheProvider");
            }
        }
        public MQProvider MQProvider
        {
            get
            {
                return BaseProvider.LoadInstance<MQProvider>("RabbitMQProvider");
            }
        }
        #endregion
    }
}

