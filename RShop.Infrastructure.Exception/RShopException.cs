using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RShop.Infrastructure.Exception
{
    public class RShopException : System.Exception
    {
        public RShopException()
        {
            ErrorCode = "00001";
        }
        /// <summary>
        /// 异常代码
        /// </summary>
        public String ErrorCode { get; set; }

        public RShopException(string errorCode) : base() { ErrorCode = errorCode; }

        public RShopException(string errorCode, string message) : base(message) { ErrorCode = errorCode; }

        public RShopException(string errorCode, SerializationInfo info, StreamingContext context) : base(info, context) { ErrorCode = errorCode; }

        public RShopException(string errorCode, string message, System.Exception innerException) : base(message, innerException) { ErrorCode = errorCode; }
    }
}
