using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RShop.Infrastructure.Message
{
    public class ResponseMessageWrap<T> where T : class, new()
    {
        public ResponseMessageWrap()
        {
            Body = new T();
            IsSuccess = true;
            ErrorCode = "00000";
        }
        public bool IsSuccess { get; set; }
        public String ErrorCode { get; set; }
        public String Message { get; set; }
        public T Body { get; set; }
    }
}
