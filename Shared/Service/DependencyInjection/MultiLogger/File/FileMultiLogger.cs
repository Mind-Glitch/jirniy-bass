namespace Shared.Service.DependencyInjection.MultiLogger.File;

public class FileMultiLogger : MultiLoggerBase
{
    public FileMultiLogger() : base(new FileMultiLoggerOptions())
    {
        
    }
    
    public FileMultiLogger(FileMultiLoggerOptions options) : base(options)
    {
        
    }
}