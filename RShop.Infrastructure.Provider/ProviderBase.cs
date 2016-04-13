using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace RShop.Infrastructure.Provider
{

    /// <summary>
    /// 提供者基类
    /// </summary>
    public abstract class ProviderBase
    {
        protected ProviderBase()
        {
        }

        public virtual void Initialize(string name, NameValueCollection config)
        {
        }

        public virtual string Description
        {
            get;
        }

        public virtual string Name
        {
            get;
        }
    }
}
