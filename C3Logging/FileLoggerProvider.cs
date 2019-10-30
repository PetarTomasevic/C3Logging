using Microsoft.Extensions.Logging;

namespace C3Logging.FileLogging
{
    public class FileLoggerProvider : ILoggerProvider
    {
        private FileLogger _FileLogger;
        public string FilePath { get; set; }

        public FileLoggerProvider(string filePath)
        {
            FilePath = filePath;
        }

        public ILogger CreateLogger(string categoryName)
        {
            _FileLogger = new FileLogger(FilePath);
            return _FileLogger;
        }

        public void Dispose()
        {
        }
    }
}