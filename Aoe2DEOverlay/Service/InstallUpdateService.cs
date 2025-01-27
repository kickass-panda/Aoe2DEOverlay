﻿using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace Aoe2DEOverlay
{
    public class InstallUpdateService
    {
        public static InstallUpdateService Instance { get; } = new ();

        public static void Initialize()
        {
            var _ = Instance;
        }
        
        static InstallUpdateService()
        {
        }

        private InstallUpdateService()
        {
            DownloadUpdateService.Instance.OnDownloadProgress += ((percentage, completed) =>
            {
                if (completed)
                {
                    UnzipUpdate().GetAwaiter().OnCompleted((() =>
                    {
                        StartUpdateManager();
                    }));
                    
                }
            });
        }

        private async Task UnzipUpdate()
        {
            var platform = Metadata.platform.ToString();
            var zipFile = $"{platform}.zip";
            var basePath = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            var zipPath = $"{basePath}/update/{zipFile}";
            var dirPath = $"{basePath}/update";
            var jsonPath = $"{dirPath}/{platform}/setting.json";
            await Task.Run(() => ZipFile.ExtractToDirectory(zipPath, dirPath));
            if(File.Exists(jsonPath)) File.Delete(jsonPath);
        }

        private void StartUpdateManager()
        {
            var platform = Metadata.platform.ToString();
            var basePath = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            var exePath = $"{basePath}/UpdateManager/{platform}/UpdateManager.exe";
            Process.Start(exePath);
            System.Windows.Application.Current.Shutdown();
        }
    }
}