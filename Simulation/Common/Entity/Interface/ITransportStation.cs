namespace Simulation.Common.Entity.Interface;

/// <summary>
/// Этот интерфейс будет запрашивать у <see cref="ITransport"/> загрузку и разгрузку
/// полезной нагрузки ( рэп )
/// </summary>
public interface ITransportStation
{
    /// <summary>
    /// todo: Добавить List&lt;LoadStuff> или что-то типа того
    /// </summary>
    bool TryLoad();
    bool TryUnload();
}