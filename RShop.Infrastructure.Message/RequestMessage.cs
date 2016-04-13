using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RShop.Infrastructure.Message
{
   public abstract class RequestMessage
    {
        public RequestMessage()
        {
            Header = new RequestHeader
            {

            };
        }

    public RequestHeader Header { get; set; }
    }

}
/// <summary>
/// 消息请求头
/// </summary>
public class RequestHeader
{
    /// <summary>
    /// 渠道
    /// </summary>
    public String Channel { get; set; }
    /// <summary>
    /// 操作人
    /// </summary>
    public long Operator { get; set; }
}
