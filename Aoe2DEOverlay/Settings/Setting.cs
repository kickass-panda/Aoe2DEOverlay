﻿using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Aoe2DEOverlay
{
    class Setting
    {
        private static string serverKey = "server";
        private static string raitingKey = "raiting";
        
        private static string profileIdKey = "profileId";
        private static string refreshIntervalKey = "refreshInterval";
        
        private JObject json = new JObject();
        
        private string basePath = "";
        private string filePath = "";
        private string fileName = "setting.json";
        
        private FileSystemWatcher watcher = new FileSystemWatcher();

        public ServerSetting Server;
        public RaitingSetting Raiting;
        
        public ISettingObserver Observer;
        
        public int ProfileId { get {
            var token = json[profileIdKey];
            if (token == null) return -1;
            return token.Value<int>();
        } }
        
        public int RefreshInterval { get {
            var token = json[refreshIntervalKey];
            if (token == null) return 5000;
            var value = token.Value<int>() * 1000;
            return value < 1000 ? 1000 : value;
        } }
        public static Setting Instance { get; } = new Setting();

        static Setting()
        {
        }

        private Setting()
        {
            var raitingJson = new JObject();
            var serverJson = new JObject();
            Raiting = new RaitingSetting(raitingJson);
            Server = new ServerSetting(serverJson);
            
            json[profileIdKey] = null;
            json[refreshIntervalKey] = 5; // sec
            json[raitingKey] = raitingJson;
            json[serverKey] = serverJson;
            
            basePath = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            filePath += $"{basePath}/{fileName}";
            if (!System.IO.File.Exists(filePath))
            {
                Save();
            }
            Load();
            watcher.Path = basePath;
            watcher.NotifyFilter = NotifyFilters.Attributes |  
                                   NotifyFilters.CreationTime |  
                                   NotifyFilters.DirectoryName |  
                                   NotifyFilters.FileName |  
                                   NotifyFilters.LastAccess |  
                                   NotifyFilters.LastWrite |  
                                   NotifyFilters.Security | 
                                   NotifyFilters.Size;
            watcher.Changed += OnChanged;
            watcher.Filter = fileName;  
            watcher.EnableRaisingEvents = true; 
        }

        public void Save()
        {
            System.IO.File.WriteAllText(filePath, json.ToString(Formatting.Indented));
        }
        
        public void Load()
        {
            try
            {
                var text = System.IO.File.ReadAllText(filePath);
                json = JObject.Parse(text);
                Raiting.Load(json[raitingKey] as JObject);
                Server.Load(json[serverKey] as JObject);
            }
            catch
            {
                // ignored
            }
        }
        
        public void OnChanged(object source, FileSystemEventArgs e)  
        {  
            Load();
            Observer?.SettingChanged();
        }  
        

    }
}
