using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RShop.Infrastructure.Message.Response.Config
{
    [XmlRoot(ElementName = "ServiceConfig", Namespace = "http://i4ta.com/schemas/ServiceConfig.xsd")]
    public class ServiceConfigResponse
    {
        public ServiceConfigResponse()
        {
            Services = new List<Service>();
        }
        public List<Service> Services { get; set; }
        #region Service Entity
        public class Service
        {
            public Service()
            {
                Controllers = new List<Controller>();
            }
            [XmlAttribute]
            public String Code { get; set; }
            [XmlAttribute]
            public String Name { get; set; }
            [XmlAttribute]
            public String Host { get; set; }
            [XmlAttribute]
            public String Description { get; set; }
            public List<Controller> Controllers { get; set; }
        }
        public class Controller
        {
            public Controller()
            {
                Actions = new List<Action>();
            }
            [XmlAttribute]
            public String Code { get; set; }
            [XmlAttribute]
            public String Name { get; set; }
            public List<Action> Actions { get; set; }
        }
        public class Action
        {
            [XmlAttribute]
            public String Code { get; set; }
            [XmlAttribute]
            public String Name { get; set; }
            [XmlAttribute]
            public String Description { get; set; }
        }
        #endregion
    }
}
