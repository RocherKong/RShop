using RShop.Infrastructure.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RShop.Infrastructure.EMail
{/// <summary>
 /// 邮件提供者
 /// </summary>
    public abstract class EMailProvider : BaseProvider
    {
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="recipient">接收人</param>
        /// <param name="subject">主题</param>
        /// <param name="body">主体内容</param>
        public abstract void Send(string recipient, string subject, string body);
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="recipient"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="isBodyHtml"></param>
        public abstract void Send(string recipient, string subject, string body, bool isBodyHtml);
        public abstract void Send(string recipient, string[] cc, string subject, string body);
        public abstract void Send(string recipient, string[] cc, string subject, string body, bool isBodyHtml);

        public abstract void Send(MailRequestMessage reqMsg);
    }
    /// <summary>
    /// 邮箱请求消息
    /// </summary>
    public class MailRequestMessage
    {
        public MailRequestMessage()
        {
            CC = new string[] { };
            InputCharset = "utf-8";
        }
        /// <summary>
        /// 收件人
        /// </summary>
        public String Recipient { get; set; }
        /// <summary>
        /// To CC
        /// </summary>
        public String[] CC { get; set; }
        /// <summary>
        /// 主题
        /// </summary>
        public String Subject { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public String Body { get; set; }
        /// <summary>
        /// 内容是否为HTML
        /// </summary>
        public bool IsBodyHtml { get; set; }
        /// <summary>
        /// 编码方式 默认 UTF8
        /// </summary>
        public String InputCharset { get; set; }
    }
}
