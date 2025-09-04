namespace Shared.Service.DependencyInjection.MultiLogger;

public interface IMultiLogger
{
    public enum LogLevel
    {
        Debug,
        Info,
        Warn,
        Error,
        Fatal
    }

    public LogLevel[] Levels { get; set; }

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

    /// <summary>
    /// Приложение выбросило ошибку, но может работать дальше
    /// </summary>
    /// <param name="ex"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public virtual Task LogError(Exception ex)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Приложение не может работать дальше. Chel paL, status : FATAL
    /// </summary>
    /// <param name="ex"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public virtual Task LogFatal(Exception ex)
    {
        throw new NotImplementedException();
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return Levels.Contains(logLevel);
    }
}