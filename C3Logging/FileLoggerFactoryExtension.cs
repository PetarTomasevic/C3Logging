﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace C3Logging.FileLogging
{
    public static class FileLoggerFactoryExtension
    {
        public static ILoggingBuilder AddFileLogging(this ILoggingBuilder builder, string filePath)
        {
            builder.Services.AddSingleton<ILoggerProvider>(_ => new FileLoggerProvider(filePath));
            return builder;
        }
    }
}