﻿using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Aoe2DEOverlay
{
    public delegate void OnSettingChange(Setting setting);
    public class Setting
    {
        private static string serverKey = "server";
        private static string raitingKey = "raiting";
        private static string updateKey = "update";
        
        private JObject json = new JObject();
        
        private string basePath = "";
        private string filePath = "";
        private string fileName = "setting.json";
        
        private FileSystemWatcher watcher = new FileSystemWatcher();

        public ServerSetting Server;
        public RaitingSetting Raiting;
        public UpdateSetting Update;

        public OnSettingChange OnSettingChange; 
        
        public static Setting Instance { get; } = new Setting();

        static Setting()
        {
        }

        private Setting()
        {
            var raitingJson = new JObject();
            var serverJson = new JObject();
            var updateJson = new JObject();
            
            Raiting = new RaitingSetting(raitingJson);
            Server = new ServerSetting(serverJson);
            Update = new UpdateSetting(updateJson);
            
            json[raitingKey] = raitingJson;
            json[serverKey] = serverJson;
            json[updateKey] = updateJson;
            
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
                Update.Load(json[updateKey] as JObject);
            }
            catch
            {
                // ignored
            }
        }
        
        public void OnChanged(object source, FileSystemEventArgs e)  
        {  
            Load();
            OnSettingChange(this);
        }  
        

    }
}
