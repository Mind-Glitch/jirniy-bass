namespace Shared.Service.DependencyInjection.MultiLogger;

/// <summary>
/// Это прокси класс, который редикертит вызовы на другие классы.
/// Пользователь регистрирует нужные классы в DI -> <see cref="IMultiLoggerBuilder"/> в
/// <see cref="MultiLoggerExtensions.AddMultiLogger"/>
/// </summary>
public class MultiLogger : MultiLoggerBase
{
    public MultiLogger() : base(new MultiLoggerOptions())
    {
    }

    public MultiLogger(MultiLoggerOptions options) : base(options)
    {
    }

    private readonly List<IMultiLogger> loggers = [];

    internal void AddLogger(IMultiLogger multiLogger)
    {
        loggers.Add(multiLogger);
    }

    public override Task LogMessage(string message) =>
        Task.WhenAll(loggers.Select(logger => logger.LogMessage(message)));
        
    public override Task LogInformation(string message) =>
        Task.WhenAll(loggers.Select(logger => logger.LogInformation(message)));

    public override Task LogDebug(string message) =>
        Task.WhenAll(loggers.Select(logger => logger.LogDebug(message)));

    public override Task LogError(Exception exception) =>
        Task.WhenAll(loggers.Select(logger => logger.LogError(exception)));

    public override Task LogFatal(Exception exception) =>
        Task.WhenAll(loggers.Select(logger => logger.LogFatal(exception)));

}