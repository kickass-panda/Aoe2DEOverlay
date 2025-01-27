﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

/*
namespace Aoe2DEOverlay
{
    public delegate void ReleaseUpdate(Version version);
    public class ReleaseUpdateService
    {
        
        public static ReleaseUpdateService Instance { get; } = new();
        
        private WebClient client = new();

        public ReleaseUpdate Subscriber;
        
        static ReleaseUpdateService()
        {
        }

        private ReleaseUpdateService()
        {
            client.DownloadProgressChanged += (sender, args) =>
            {
                Console.WriteLine($"zip progress {args.ProgressPercentage}%");
            };
            client.DownloadFileCompleted += (sender, args) =>
            {
                Console.WriteLine("zip downloaded");
            };
        }

        public async void CheckRelease()
        {
            var jarray = await FetchReleases() as JArray;
            
            if(jarray == null) return;

            foreach (var json in jarray)
            {
                var name = json["name"].Value<string>();
                var tag = json["tag_name"].Value<string>().TrimStart('v');
                if(tag != name) continue;

                var isPrerelease = json["prerelease"].Value<bool>();
                if(isPrerelease && !Setting.Instance.Update.Prerelease) continue;

                var version = new Version(tag);
                if(Metadata.Version >= version) continue;

                var now = DateTime.Now;
                var date = json["published_at"].Value<DateTime>();
                var delta = (now - date).TotalHours;
                var waiting = Setting.Instance.Update.Waiting;
                if(delta < 1 && Setting.Instance.Update.Waiting) continue;
                DownloadReleaase(json);
                break;
            }
            
        }

        public void DownloadReleaase(JToken json)
        {
            var assets = json["assets"].Values<JObject>();
            foreach (var asset in assets)
            {
                var name = asset["name"]?.Value<string>() ?? "";
                var platform = Metadata.platform.ToString();
                if(name == $"{platform}.zip")
                {
                    var url = asset["browser_download_url"]?.Value<string>() ?? "";
                    DownloadZip(url, name);
                    //UnzipRelease();
                }
            }
        }

        private void DownloadZip(string url, string fileName)
        {
            var basePath = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            var filePath = $"{basePath}/update/{fileName}";
            client.DownloadFileAsync(new Uri(url), filePath);
        }

        private void UnzipRelease()
        {
            var platform = Metadata.platform.ToString();
            var fileName = $"{platform}.zip";
            var basePath = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            var zipPath = $"{basePath}/update/{fileName}";
            var extractPath = $"{basePath}/update/{platform}";
            // https://stackoverflow.com/questions/836736/unzip-files-programmatically-in-net
            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
        }

        private async Task<JToken> FetchReleases()
        {
            var url = "https://api.github.com/repos/kickass-panda/Aoe2DEOverlay/releases";
            var headers = new Dictionary<string, string>()
            {
                { "User-Agent", "request" },
            };
            return await Http.FetchJSON(url, headers);
        }

    }
}
*/