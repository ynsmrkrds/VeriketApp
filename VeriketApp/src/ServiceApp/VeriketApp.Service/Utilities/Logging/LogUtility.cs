namespace VeriketApp.Service.Utilities.Logging
{
    public class LogUtility
    {
        private readonly Abstract.ILogger _logger;

        public LogUtility(Abstract.ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.Log(message);
        }
    }
}
