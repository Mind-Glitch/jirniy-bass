namespace Simulation.Common.WorldGeneration;

public record struct WorldGeneratorOptions
{
    public bool SoftSurface { get; init; }
    /// <summary>
    /// Как таковых пещер не будет, но будут сущности, которые будут олицетворять пещеры.
    /// Туда можно будет отправить экспедицию, но делать там ничего нельзя будет. Можно
    /// ещё будет ресурсы добывать там.
    /// </summary>
    public bool Caves { get; init; }
    public bool Queries { get; init; }
    public bool Resources { get; init; }
}