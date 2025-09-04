namespace Shared.Service.DependencyInjection.MultiLogger;

/// <summary>
/// <p> Возможно можно будет для всех логгеров потом использовать это. Типа по паттерну
/// это сделалать нужно, но на момент написания этот класс лишний. </p>
///<p> Можно в него указать логику ДО вызова остальных логгеров и регать это в
/// <see cref="MultiLoggerExtensions.AddMultiLogger"/></p>
/// </summary>
public class MultiLoggerOptions : MultiLoggerOptionsBase
{
}