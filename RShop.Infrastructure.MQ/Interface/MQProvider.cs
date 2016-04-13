using RShop.Infrastructure.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RShop.Infrastructure.MQ.Interface
{
    /// <summary>
    /// 消息队列提供者
    /// </summary>
    public abstract class MQProvider : BaseProvider, IDisposable
    {
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="qName">队列名称</param>
        /// <param name="msg"></param>
        public abstract void SendMessage<T>(String qName, T msg) where T : class;

        /// <summary>
        /// 订阅消息并处理-AllWays
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="qName">队列名称</param>
        /// <param name="allwaysRunAction">持续执行函数</param>
        public abstract void Listen<T>(string qName, Func<T, bool> allwaysRunAction) where T : class;

        public abstract void Dispose();
    }
}
