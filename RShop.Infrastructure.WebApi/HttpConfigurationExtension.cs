using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace RShop.Infrastructure.WebApi
{
    public static class HttpConfigurationExtension
    {
        /// <summary>
        /// 移除XML支持
        /// </summary>
        /// <param name="httpConfig"></param>
        public static void RemoveXmlFormatter(this HttpConfiguration httpConfig)
        {
            var appXmlType = httpConfig.Formatters.XmlFormatter.SupportedMediaTypes.
FirstOrDefault(t => t.MediaType == "application/xml");

            httpConfig.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}
