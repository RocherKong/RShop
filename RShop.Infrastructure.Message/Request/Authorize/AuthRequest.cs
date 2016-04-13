using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RShop.Infrastructure.Message.Request.Authorize
{
   public class AuthRequest:RequestMessage
    {
        public String AppId { get; set; }

        public String AppSecret { get; set; }
    }
}
