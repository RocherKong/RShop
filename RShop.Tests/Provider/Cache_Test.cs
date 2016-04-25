using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using RShop.Infrastructure.Cache.Interface;

namespace RShop.Tests.Provider
{
    [TestClass]
    public class Cache_Test
    {
       public CacheProvider CacheProvider
        {
            get {
                return CacheProvider.LoadInstance<CacheProvider>("RedisCacheProvider");
            }
        }

        [TestMethod]
        public void Cache_AddTest()
        {
            string token = Guid.NewGuid().ToString("N");
            bool isSuccess = CacheProvider.Add<String>(String.Format("Token:{0}",token),"孔翔的token");
            Assert.IsTrue(isSuccess);
        }
    }
}
