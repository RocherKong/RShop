using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace RShop.Infrastructure.Utilities
{
    /// <summary>
    /// Xml序列化、反序列化 帮助类
    /// </summary>
    public class XMLHelper
    {
        public static T Deserialize<T>(Stream xmlStream) where T : class
        {
            XmlSerializer xmlSearializer = new XmlSerializer(typeof(T));
            return xmlSearializer.Deserialize(xmlStream) as T;
        }

        public static T Deserialize<T>(String xmlString) where T : class
        {
            byte[] strBytes = Encoding.UTF8.GetBytes(xmlString);
            using (Stream stream = new MemoryStream(strBytes))
            {
                XmlSerializer xmlSearializer = new XmlSerializer(typeof(T));
                return xmlSearializer.Deserialize(stream) as T;
            }
        }
        public static T DeserializeByFilePath<T>(String fullPath) where T : class
        {
            using (StreamReader streamReader = new StreamReader(fullPath))
            {
                XmlSerializer xmlSearializer = new XmlSerializer(typeof(T));
                return (xmlSearializer.Deserialize(streamReader) as T);
            }
        }


        public static String Serialize<T>(T obj)
        {
            XmlSerializer xmlSearializer = new XmlSerializer(typeof(T));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            MemoryStream stream = new MemoryStream();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UTF8Encoding(false);
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(stream, settings))
            {
                xmlSearializer.Serialize(writer, obj, ns);
            }
            return Encoding.UTF8.GetString(stream.ToArray());
        }

    }
}
