namespace Shared.Service.DependencyInjection.MultiLogger.Console;

public class ConsoleMultiLogger : MultiLoggerBase
{
    public ConsoleMultiLogger() : base(new ConsoleMultiLoggerOptions())
    {
    }

    public ConsoleMultiLogger(ConsoleMultiLoggerOptions options) : base(options)
    {
    }

    public override Task LogMessage(string message)
    {
        System.Console.WriteLine(message);
        return Task.CompletedTask;
    }

    public override Task LogInformation(string message)
    {
        System.Console.ForegroundColor = ConsoleColor.DarkCyan;
        System.Console.WriteLine(message);
        System.Console.ResetColor();
        return Task.CompletedTask;
    }

    public override Task LogDebug(string message)
    {
        System.Console.ForegroundColor = System.ConsoleColor.Yellow;
        System.Console.WriteLine(message);
        System.Console.ResetColor();
        return Task.CompletedTask;
    }

    public override Task LogError(Exception exception)
    {
        System.Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine(exception);
        System.Console.ResetColor();
        return Task.CompletedTask;
    }

    public override Task LogFatal(Exception exception)
    {
        System.Console.ForegroundColor = System.ConsoleColor.DarkRed;
        System.Console.WriteLine(exception);
        System.Console.ResetColor();
        return Task.CompletedTask;
    }
}