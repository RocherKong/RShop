using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RShop.Infrastructure.MQ.Interface;
using RShop.Infrastructure.Provider;
using RShop.TradingCenter.Entity;

namespace RShop.Tests.Provider
{
    [TestClass]
    public class MQ_Test
    {
        public MQProvider MQProvider { get { return BaseProvider.LoadInstance<MQProvider>("RabbitMQProvider"); } }
        [TestMethod]
        public void MQ_Test1()
        {
            MQProvider.SendMessage("testMq", new T_Banner
            {
                Id=1
            });
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Consume()
        {
            MQProvider.Listen<T_Banner>("testMq", RunTask);

            Assert.IsTrue(true);
        }

        public bool RunTask(T_Banner inviteMember)
        {

            if (inviteMember.Id == 1)
            {
                return true;
            }
            else
            { return false; }
        }
    }
}
