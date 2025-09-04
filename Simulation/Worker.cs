using Simulation.Common.Exceptions;
using Shared.Service.DependencyInjection.MultiLogger;

namespace Simulation;

public class Worker : BackgroundService
{
    private readonly IMultiLogger _logger;
    private readonly IHostApplicationLifetime _hostApplicationLifetime;

    public Worker(IMultiLogger logger, IHostApplicationLifetime hostApplicationLifetime)
    {
        _logger = logger;
        _hostApplicationLifetime = hostApplicationLifetime;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var timeNow = DateTime.UtcNow;
        await _logger.LogInformation(
            "Контейнер запущен. Идёт подготовка к старту симуляции. " +
            $"Время за бортом : {timeNow:HH:mm:ss zz, MM/dd/yyyy} UTC.");

        await _logger.LogInformation("Производится подготовка ресурсов...");
        /* Загружать ресурсы и генерировать контент ... */

        await _logger.LogInformation("Запуск симуляции ... ");

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                /*  Основной код    */

                // симуляция работы до того как появится работа.
                await Task.Delay(10, stoppingToken);
                break;
            }
            catch (SimulationException ex)
            {
                await _logger.LogError(ex);
            }
            catch (FatalException ex)
            {
                await _logger.LogError(ex);
                break;
            }
        }

        await _logger.LogInformation("Запрошена остановка симуляции ...");

        /* Отстановка здесь:  */

        await _logger.LogInformation("Симуляция остановлена. Отключение от сети ...");
        /* Отключение всех логгеров, gRPC и так далее, закрытие контейнера ... */

        _hostApplicationLifetime.StopApplication();
    }
}