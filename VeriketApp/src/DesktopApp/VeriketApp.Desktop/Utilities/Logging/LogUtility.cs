using VeriketApp.Desktop.Models;
using VeriketApp.Desktop.Utilities.Logging.Abstract;

namespace VeriketApp.Desktop.Utilities.Logging
{
    public class LogUtility
    {
        private readonly ILogger _logger;

        public LogUtility(ILogger logger)
        {
            _logger = logger;
        }

        public List<LogModel> GetLogs()
        {
            return _logger.GetLogs();
        }
    }
}
