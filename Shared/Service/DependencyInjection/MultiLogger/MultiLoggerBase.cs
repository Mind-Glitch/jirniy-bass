namespace Shared.Service.DependencyInjection.MultiLogger;

public class MultiLoggerBase : IMultiLogger
{
    protected MultiLoggerBase(MultiLoggerOptionsBase options)
    {
        Levels = options.Levels;
    }

    /* Все выбраны по умолчанию */
    public IMultiLogger.LogLevel[] Levels { get; set; } = [];

    public virtual Task LogMessage(string message)
    {
        throw new NotImplementedException();
    }

    public virtual Task LogDebug(string message)
    {
        throw new NotImplementedException();
    }

    public virtual Task LogInformation(string message)
    {
        throw new NotImplementedException();
    }

    public virtual Task LogFatal(Exception exception)
    {
        throw new NotImplementedException();
    }

    public virtual Task LogError(Exception message)
    {
        throw new NotImplementedException();
    }
}