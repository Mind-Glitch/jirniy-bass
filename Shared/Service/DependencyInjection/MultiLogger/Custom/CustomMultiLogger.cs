namespace Shared.Service.DependencyInjection.MultiLogger.Custom;

public class CustomMultiLogger : MultiLoggerBase
{
    public CustomMultiLogger() : base(new CustomMultiLoggerOptions())
    {
    }

    public CustomMultiLogger(CustomMultiLoggerOptions options) : base(options)
    {
    }
}