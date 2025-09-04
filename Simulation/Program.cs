using Shared.Service.DependencyInjection.MultiLogger;

namespace Simulation;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);
        builder.Services.AddHostedService<Worker>();

        builder.Services.AddGrpc(options => { options.EnableDetailedErrors = true; });

        builder.Services.AddMultiLogger(options => { })
            .AddConsoleLogger(options => { });
            
        var host = builder.Build();
        host.Run();
    }
}