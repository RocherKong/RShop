using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Framing;
using RShop.Infrastructure.MQ.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RShop.Infrastructure.MQ
{
    public class RabbitMQProvider : MQProvider
    {
        private IConnectionFactory connFactory;

        #region 保持长连接
        private IConnection SendConnection;
        private IConnection ListenConnection;
        #endregion

        public String HostName { get; private set; }
        public String UserName { get; private set; }
        public String Password { get; private set; }
        /// <summary>
        /// 消息持久化
        /// </summary>
        private bool durable = true;
        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config)
        {
            HostName = config["HostName"];
            if (String.IsNullOrEmpty(HostName))
            {
                throw new Exception("HostName string can't empty.");
            }

            UserName = config["UserName"];
            if (String.IsNullOrEmpty(UserName))
            {
                throw new Exception("UserName string can't empty.");
            }

            Password = config["Password"];
            if (String.IsNullOrEmpty(Password))
            {
                throw new Exception("Password string can't empty.");
            }
            ushort heartbeat = 60;
            connFactory = new ConnectionFactory()
            {
                HostName = HostName,
                UserName = UserName,
                Password = Password,
                RequestedHeartbeat = heartbeat,
                AutomaticRecoveryEnabled = true
            };
            base.Initialize(name, config);
        }

        /// <summary>
        /// 发布消息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="qName"></param>
        /// <param name="msg"></param>
        public override void SendMessage<T>(string qName, T msg)
        {
            if (!(SendConnection != null && SendConnection.IsOpen))
            {
                SendConnection = connFactory.CreateConnection();
            }
            using (var channel = SendConnection.CreateModel())
            {
                channel.QueueDeclare(qName, durable, false, false, null);
                string message = JsonConvert.SerializeObject(msg);
                var body = Encoding.UTF8.GetBytes(message);
                BasicProperties basicProperties = new BasicProperties { Persistent = true };
                channel.BasicPublish("", qName, basicProperties, body);
            }
        }

        /// <summary>
        /// 订阅消息并处理-AllWays
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="qName"></param>
        /// <param name="allwaysRunAction">持续执行函数</param>
        public override void Listen<T>(string qName, Func<T, bool> allwaysRunAction)
        {
            if (!(ListenConnection != null && ListenConnection.IsOpen))
            {
                ListenConnection = connFactory.CreateConnection();
            }

            var listenChannel = ListenConnection.CreateModel();

            listenChannel.QueueDeclare(qName, durable, false, false, null);
            var consumer = new EventingBasicConsumer(listenChannel);
            consumer.Received += (model, ea) =>
            {
                var message = Encoding.UTF8.GetString(ea.Body);
                T resp = JsonConvert.DeserializeObject<T>(message);
                bool isSuccess = allwaysRunAction(resp);

                if (isSuccess)
                {
                    listenChannel.BasicAck(ea.DeliveryTag, false);
                }
                else
                {
                    listenChannel.BasicNack(ea.DeliveryTag, false, true);
                }
            };
            listenChannel.BasicQos(0, 1, false);
            listenChannel.BasicConsume(qName, false, consumer);
        }

        public override void Dispose()
        {
            SendConnection.Close();
            ListenConnection.Close();
        }
    }
}
