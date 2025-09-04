using Microsoft.Extensions.DependencyInjection;

namespace Shared.Service.DependencyInjection.MultiLogger;

public static class MultiLoggerExtensions
{
    /// <summary>
    /// <p>
    /// Используйте <see cref="IMultiLoggerBuilder"/> методы чтобы добавить логгеры!
    ///</p>
    /// <p>
    /// <see cref="IMultiLoggerBuilder"/> сам по себе ничего не добавляет!
    /// </p>
    /// </summary>
    /// <param name="serviceProvider">Standard <see cref="IServiceCollection"/></param>
    /// <param name="generalOptions">Конфигурации для самой процедуры вызова всех
    /// добавленных логгеров</param>
    /// <returns></returns>
    public static IMultiLoggerBuilder AddMultiLogger(
        this IServiceCollection serviceProvider,
        Action<MultiLoggerOptions>? generalOptions = null)
    {
        var options = new MultiLoggerOptions();
        generalOptions?.Invoke(options);

        var multiLogger = new MultiLogger(options);

        serviceProvider.AddSingleton<IMultiLogger>(multiLogger);
        return new MultiLoggerBuilder(multiLogger);
    }
}