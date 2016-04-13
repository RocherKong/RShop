using Newtonsoft.Json;
using RShop.Infrastructure.Cache.Interface;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RShop.Infrastructure.Cache.Impl
{
    /// <summary>
    /// Redis Cache 缓存提供者
    /// </summary>
    public class RedisCacheProvider : CacheProvider
    {
        private ConnectionMultiplexer connection;
        private IDatabase cacheDB { get { return connection.GetDatabase(); } }
        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config)
        {
            base.Initialize(name, config);
            String connStr = config["ConnectionString"];
            if (String.IsNullOrEmpty(connStr))
            {
                throw new Exception("ConnectionString string can't empty.");
            }
            connection = ConnectionMultiplexer.Connect(connStr);
        }
        public override bool Add<T>(string key, T item)
        {
            return Add<T>(key, item, null);
        }
        public override bool Add<T>(string key, T item, TimeSpan? expiry)
        {
            String data = JsonConvert.SerializeObject(item);
            return cacheDB.StringSet(key, data, expiry);
        }
        public override bool Remove(string key)
        {
            return cacheDB.KeyDelete(key);
        }
        public override bool Update<T>(string key, T item)
        {
            String data = JsonConvert.SerializeObject(item);
            return cacheDB.StringSet(key, data);
        }
        public override T Get<T>(string key)
        {
            string data = cacheDB.StringGet(key);
            return JsonConvert.DeserializeObject<T>(data);
        }
        public override object Get(string key, Type type)
        {
            string data = cacheDB.StringGet(key);
            return JsonConvert.DeserializeObject(data, type);
        }
        public override bool Exisit(string key)
        {
            return cacheDB.KeyExists(key);
        }


    }
}
