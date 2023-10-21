using Microsoft.Win32;
using System.Runtime.InteropServices;
using VeriketApp.Service.Utilities.Logging;

namespace VeriketApp.Service.Workers
{
    public class LoggingWorker : BackgroundService
    {
        private readonly LogUtility _logUtility;

        public LoggingWorker(LogUtility logUtility)
        {
            _logUtility = logUtility;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logUtility.Log($"[{DateTime.Now}] [{Environment.MachineName}] [{LoggedInUserName()}]");
                await Task.Delay(60 * 1000, stoppingToken);
            }
        }

        private static string LoggedInUserName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                using RegistryKey? registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI");
                string? userName = registryKey?.GetValue("LastLoggedOnUser")?.ToString();
                if (userName is null) return string.Empty;

                if (userName.Contains(".\\") == true)
                {
                    userName = userName.Replace(".\\", "");
                }

                return userName;
            }
            else
            {
                return Environment.UserName;
            }
        }
    }
}