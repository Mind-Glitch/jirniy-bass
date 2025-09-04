namespace Shared.Service.DependencyInjection.MultiLogger;

public abstract class MultiLoggerOptionsBase
{
    /* All enabled by default */
    public IMultiLogger.LogLevel[] Levels { get; set; } =
    [
        IMultiLogger.LogLevel.Debug,
        IMultiLogger.LogLevel.Info,
        IMultiLogger.LogLevel.Warn,
        IMultiLogger.LogLevel.Error,
        IMultiLogger.LogLevel.Fatal,
    ];
    
    public string LogPrefix { get; set; } = "[LOG]";
    public string DebugPrefix { get; set; } = "[DEBUG]";
    public string InfoPrefix { get; set; } = "[INFO]";
    public string ErrorPrefix { get; set; } = "[ERROR]";
    public string FatalPrefix { get; set; } = "[FATAL ERROR]";
    
}