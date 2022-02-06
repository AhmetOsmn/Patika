using System;

namespace _15.OOP
{
    public class LogManager : ILogger
    {
        public ILogger _logger;

        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}