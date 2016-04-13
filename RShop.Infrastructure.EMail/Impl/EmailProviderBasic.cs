using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RShop.Infrastructure.EMail.Impl
{
    /// <summary>
    /// 基础邮件提供者
    /// </summary>
    public class EMailProviderBasic : EMailProvider
    {
        #region 初始化邮箱配置
        private static string sendNickName = string.Empty;
        private static SmtpSetting smtpSetting;
        #endregion

        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config)
        {
            if (String.IsNullOrEmpty(config["Host"]))
            {
                throw new ArgumentNullException("Host");
            }
            if (String.IsNullOrEmpty(config["UserName"]))
            {
                throw new ArgumentNullException("UserName");
            }
            if (String.IsNullOrEmpty(config["Password"]))
            {
                throw new ArgumentNullException("Password");
            }
            if (String.IsNullOrEmpty(config["Port"]))
            {
                throw new ArgumentNullException("Port");
            }
            if (!String.IsNullOrEmpty(config["NickName"]))
            {
                sendNickName = config["NickName"];
            }
            smtpSetting = new SmtpSetting
            {
                Host = config["Host"],
                UserName = config["UserName"],
                Password = config["Password"],
                Port = int.Parse(config["Port"])
            };

            base.Initialize(name, config);
        }

        private static void Send(string server, string sender, string recipient, string[] cc, string subject,
string body, bool isBodyHtml, Encoding encoding, bool isAuthentication, params string[] files)
        {
            SmtpClient smtpClient = new SmtpClient(server);
            MailMessage message = new MailMessage(sender, recipient);
            message.IsBodyHtml = isBodyHtml;

            message.SubjectEncoding = encoding;
            message.BodyEncoding = encoding;

            message.Subject = subject;
            message.Body = body;
            if (!String.IsNullOrEmpty(sendNickName))
            {
                message.From = new MailAddress(sender, sendNickName);
            }
            foreach (string c in cc)
            {
                message.CC.Add(new MailAddress(c));
            }

            message.Attachments.Clear();
            if (files != null && files.Length != 0)
            {
                for (int i = 0; i < files.Length; ++i)
                {
                    Attachment attach = new Attachment(files[i]);
                    message.Attachments.Add(attach);
                }
            }

            if (isAuthentication == true)
            {
                smtpClient.Credentials = new NetworkCredential(smtpSetting.UserName,
                    smtpSetting.Password);
            }
            smtpClient.Send(message);
        }

        public override void Send(string recipient, string subject, string body)
        {
            Send(smtpSetting.Host, smtpSetting.UserName, recipient, new string[] { }, subject, body, true, Encoding.UTF8, true, null);
        }
        public override void Send(string recipient, string subject, string body, bool isBodyHtml)
        {
            Send(smtpSetting.Host, smtpSetting.UserName, recipient, new string[] { }, subject, body, isBodyHtml, Encoding.UTF8, true, null);
        }
        public override void Send(string recipient, string[] cc, string subject, string body)
        {
            Send(smtpSetting.Host, smtpSetting.UserName, recipient, cc, subject, body, true, Encoding.UTF8, true, null);
        }
        public override void Send(string recipient, string[] cc, string subject, string body, bool isBodyHtml)
        {
            Send(smtpSetting.Host, smtpSetting.UserName, recipient, cc, subject, body, isBodyHtml, Encoding.UTF8, true, null);
        }

        public override void Send(MailRequestMessage reqMsg)
        {

            Send(
                server: smtpSetting.Host,
                sender: smtpSetting.UserName,
                recipient: reqMsg.Recipient,
                cc: reqMsg.CC,
                subject: reqMsg.Subject,
                body: reqMsg.Body,
                isBodyHtml: reqMsg.IsBodyHtml,
                encoding: Encoding.GetEncoding(reqMsg.InputCharset),
                isAuthentication: true,
                files: null
                );
        }
    }

    /// <summary>
    /// 邮箱配置实体
    /// </summary>
    public class SmtpSetting
    {
        public String Host { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public int Port { get; set; }
    }
}
