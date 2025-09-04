namespace Shared.Service.DependencyInjection.MultiLogger.RabbitMQ;

public class RabbitMqMultiLogger : MultiLoggerBase
{
    public RabbitMqMultiLogger() : base(new RabbitMqMultiLoggerOptions())
    {
        
    }
    
    public RabbitMqMultiLogger(RabbitMqMultiLoggerOptions options) : base(options)
    {
        
    }
}