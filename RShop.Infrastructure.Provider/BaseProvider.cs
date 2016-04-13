using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RShop.Infrastructure.Provider
{
    /// <summary>
    /// 提供者基类
    /// </summary>
    public abstract class BaseProvider : ProviderBase
    {
        static BaseProvider()
        {
            ProviderLoader.Instance.ConfigChanged = (ProviderLoader) =>
            {
                ProviderContainer.Clear();
            };
        }
        /// <summary>
        /// 同步锁
        /// </summary>
        private static readonly object syncRoot = new object();

        /// <summary>
        /// 提供者容器
        /// </summary>
        private static Hashtable ProviderContainer = new Hashtable();
        /// <summary>
        /// 加载提供者实例
        /// 建议使用 属性形式，享受动态配置功能
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="providerName"></param>
        /// <returns></returns>
        public static T LoadInstance<T>(String providerName) where T : ProviderBase
        {
            if (ProviderContainer[providerName] == null)
            {
                lock (syncRoot)
                {
                    if (ProviderContainer[providerName] == null)
                    {
                        var providerConfig = ProviderLoader.Instance.LoadProvider(providerName);
                        T mqProvider = Assembly.Load(providerConfig.AssemblyString)
                            .CreateInstance(providerConfig.TypeName) as T;
                        NameValueCollection nvCol = new NameValueCollection();
                        
                        foreach (var nv in providerConfig.Parameters)
                        {
                            nvCol.Add(nv.Key, nv.Value);
                        }
                        mqProvider.Initialize(providerName, nvCol);

                        ProviderContainer.Add(providerName, mqProvider);
                    }
                }
            }
            return ProviderContainer[providerName] as T;
        }


    }
}
