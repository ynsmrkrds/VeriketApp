namespace VeriketApp.Service.Utilities.Logging.Concrete
{
    public class FileLogger : Abstract.ILogger
    {
        private const string _logFolderName = "VeriketApp";
        private const string _logFileName = "VeriketAppTest.txt";

        public void Log(string message)
        {
            using StreamWriter writer = new(LogFilePath(), true);
            writer.WriteLine(message);
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
