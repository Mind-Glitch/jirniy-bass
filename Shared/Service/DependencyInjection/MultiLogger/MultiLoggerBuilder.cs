using Shared.Service.DependencyInjection.MultiLogger.Console;
using Shared.Service.DependencyInjection.MultiLogger.Custom;
using Shared.Service.DependencyInjection.MultiLogger.File;
using Shared.Service.DependencyInjection.MultiLogger.RabbitMQ;

namespace Shared.Service.DependencyInjection.MultiLogger;

internal class MultiLoggerBuilder : IMultiLoggerBuilder
{
    // Append loggers into this => 
    private readonly MultiLogger _multiLogger;

    public MultiLoggerBuilder(MultiLogger multiLogger)
    {
        _multiLogger = multiLogger;
    }

    public IMultiLoggerBuilder AddRabbitMQLogger(IRabbitMqMultiLogger multiLogger)
    {
        _multiLogger.AddLogger(multiLogger);
        return this;
    }

    public IMultiLoggerBuilder AddRabbitMQLogger(
        Action<RabbitMqMultiLoggerOptions> optionsBuilder)
    {
        RabbitMqMultiLoggerOptions options = new RabbitMqMultiLoggerOptions();
        optionsBuilder(options);

        _multiLogger.AddLogger(new RabbitMqMultiLogger(options));
        return this;
    }

    public IMultiLoggerBuilder AddFileLogger(IFileMultiLogger multiLogger)
    {
        _multiLogger.AddLogger(multiLogger);
        return this;
    }

    public IMultiLoggerBuilder AddFileLogger(
        Action<FileMultiLoggerOptions> optionsBuilder)
    {
        FileMultiLoggerOptions options = new FileMultiLoggerOptions();
        optionsBuilder(options);

        _multiLogger.AddLogger(new FileMultiLogger(options));
        return this;
    }

    public IMultiLoggerBuilder AddConsoleLogger(IConsoleMultiLogger multiLogger)
    {
        _multiLogger.AddLogger(multiLogger);
        return this;
    }

    public IMultiLoggerBuilder AddConsoleLogger(
        Action<ConsoleMultiLoggerOptions> optionsBuilder)
    {
        ConsoleMultiLoggerOptions options = new ConsoleMultiLoggerOptions();
        optionsBuilder(options);

        _multiLogger.AddLogger(new ConsoleMultiLogger(options));
        return this;
    }

    public IMultiLoggerBuilder AddCustomLogger(ICustomMultiLogger multiLogger)
    {
        _multiLogger.AddLogger(multiLogger);
        return this;
    }

    public IMultiLoggerBuilder AddCustomLogger(
        Action<CustomMultiLoggerOptions> optionsBuilder)
    {
        CustomMultiLoggerOptions options = new CustomMultiLoggerOptions();
        optionsBuilder(options);

        _multiLogger.AddLogger(new CustomMultiLogger(options));
        return this;
    }
}