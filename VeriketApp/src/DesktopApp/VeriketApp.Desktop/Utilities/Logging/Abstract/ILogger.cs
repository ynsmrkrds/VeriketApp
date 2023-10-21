using VeriketApp.Desktop.Models;

namespace VeriketApp.Desktop.Utilities.Logging.Abstract
{
    public interface ILogger
    {
        List<LogModel> GetLogs();
    }
}
