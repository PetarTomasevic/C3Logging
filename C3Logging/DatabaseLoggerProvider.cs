using Microsoft.Extensions.Logging;

namespace C3Logging.DatabaseLogging
{
    public class DatabaseLoggerProvider : ILoggerProvider
    {
        private DatabaseLogger _DatabaseLogger;
        public string ConnectionString { get; set; }

        public DatabaseLoggerProvider(string connStr)
        {
            ConnectionString = connStr;
        }

        public ILogger CreateLogger(string categoryName)
        {
            _DatabaseLogger = new DatabaseLogger(ConnectionString);
            return _DatabaseLogger;
        }

        public void Dispose()
        {
        }
    }
}