using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RShop.Infrastructure.Provider
{
    public class ProviderLoader
    {
        /// <summary>
        /// 默认ProviderConfig路径
        /// </summary>
        private string configPath = "Config/Provider.xml";

        /// <summary>
        /// 配置文件全路径
        /// </summary>
        protected String ConfigFullPath { get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configPath); } }

        private static ProviderLoader instance;
        #region 配置文件监控
        private FileSystemWatcher fileWatcher;
        public Action<ProviderLoader> ConfigChanged { get; set; }
        #endregion
        private static readonly object syncLock = new object();
        public IList<Provider> Providers { get; private set; }

        private ProviderLoader()
        {
            LoadConfig(ConfigFullPath);
            WatchConfig(ConfigFullPath);
        }

        private void LoadConfig(string fullPath)
        {
            using (FileStream streamReader = new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                XmlSerializer xmlSearializer = new XmlSerializer(typeof(ProviderConfig));
                ProviderConfig config = xmlSearializer.Deserialize(streamReader) as ProviderConfig;
                Providers = config.Providers;
            }
        }

        /// <summary>
        /// 监视配置文件改动
        /// </summary>
        /// <param name="filePath">配置文件路径</param>
        private void WatchConfig(string filePath)
        {
            string directoryName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            fileWatcher = new FileSystemWatcher(directoryName);
            fileWatcher.Filter = fileName;
            fileWatcher.NotifyFilter = NotifyFilters.LastWrite;
            fileWatcher.Changed += FileWatcher_Changed;
            fileWatcher.EnableRaisingEvents = true;
        }
        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        private DateTime lastChangedTime = DateTime.Now;
        /// <summary>
        /// 俩次修改时间间隔-(毫秒)
        /// </summary>
        private int twoTimeInterval = 500;
        private void FileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            var timerInterval = (DateTime.Now - lastChangedTime).TotalMilliseconds;
            if (timerInterval < twoTimeInterval) { return; }
            LoadConfig(ConfigFullPath);
            if (ConfigChanged != null)
            {
                ConfigChanged(Instance);
            }
            lastChangedTime = DateTime.Now;
        }

        public static ProviderLoader Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncLock)
                    {
                        if (instance == null)
                        {
                            instance = new ProviderLoader();
                        }
                    }
                }
                return instance;
            }
        }

        public Provider LoadProvider(String ProviderName)
        {
            return Providers.First(m => m.Name == ProviderName);
        }
    }
    [XmlRoot(ElementName = "ProviderConfig", Namespace = "http://ahoo.me/schemas/ProviderConfig.xsd")]
    public class ProviderConfig
    {
        public List<Provider> Providers { get; set; }
    }

    public class Provider
    {
        [XmlAttribute]
        public String Name { get; set; }
        [XmlAttribute]
        public String Type { get; set; }
        public List<Parameter> Parameters { get; set; }

        [XmlIgnore]
        public String TypeName { get { return Type.Split(',')[0]; } }
        [XmlIgnore]
        public String AssemblyString { get { return Type.Split(',')[1]; } }

    }
    public class Parameter
    {
        [XmlAttribute]
        public String Key { get; set; }
        [XmlAttribute]
        public String Value { get; set; }
    }
}
