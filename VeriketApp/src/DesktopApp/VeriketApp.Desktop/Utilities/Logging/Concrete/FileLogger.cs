using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using VeriketApp.Desktop.Models;
using VeriketApp.Desktop.Utilities.Logging.Abstract;

namespace VeriketApp.Desktop.Utilities.Logging.Concrete
{
    public class FileLogger : ILogger
    {
        private const string _logFolderName = "VeriketApp";
        private const string _logFileName = "VeriketAppTest.txt";

        public List<LogModel> GetLogs()
        {
            List<LogModel> logs = new();

            using StreamReader reader = new(LogFilePath());
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('[', ']');

                logs.Add(new LogModel(DateTime.Parse(parts[1]), parts[3], parts[5]));
            }

            return logs;
        }

        private static string LogFilePath()
        {
            string systemRoot = Path.GetPathRoot(Environment.SystemDirectory)!;
            string logFolderPath = $"{systemRoot}ProgramData\\{_logFolderName}";

            if (Directory.Exists(logFolderPath) == false)
            {
                Directory.CreateDirectory(logFolderPath);
            }

            return $"{logFolderPath}\\{_logFileName}";
        }
    }
}
