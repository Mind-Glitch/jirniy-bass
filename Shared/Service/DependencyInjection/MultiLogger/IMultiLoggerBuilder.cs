using Shared.Service.DependencyInjection.MultiLogger.Console;
using Shared.Service.DependencyInjection.MultiLogger.Custom;
using Shared.Service.DependencyInjection.MultiLogger.File;
using Shared.Service.DependencyInjection.MultiLogger.RabbitMQ;

namespace Shared.Service.DependencyInjection.MultiLogger;

public interface IMultiLoggerBuilder
{
    public IMultiLoggerBuilder AddRabbitMQLogger(IRabbitMqMultiLogger multiLogger);
    public IMultiLoggerBuilder AddRabbitMQLogger(Action<RabbitMqMultiLoggerOptions> optionsBuilder);
    
    public IMultiLoggerBuilder AddFileLogger(IFileMultiLogger multiLogger);
    public IMultiLoggerBuilder AddFileLogger(Action<FileMultiLoggerOptions> options);
    
    public IMultiLoggerBuilder AddConsoleLogger(IConsoleMultiLogger multiLogger);
    public IMultiLoggerBuilder AddConsoleLogger(Action<ConsoleMultiLoggerOptions> options);
    
    public IMultiLoggerBuilder AddCustomLogger(ICustomMultiLogger multiLogger);
    public IMultiLoggerBuilder AddCustomLogger(Action<CustomMultiLoggerOptions> logger);
}