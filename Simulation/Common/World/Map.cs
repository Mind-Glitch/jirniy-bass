using Simulation.Common.WorldGeneration;

namespace Simulation.Common.World;

public class Map
{
    private readonly Dictionary<(int x, int y), MapPoint[,]> map = [];

    public MapPoint[,] FindOrCreateChunk(int x, int y)
    {
        if (map.TryGetValue((x, y), out var mapFragment))
            return mapFragment;

        var generatorOptions = new WorldGeneratorOptions
        {
            SoftSurface = true,
        };
        
        var generator = new WorldGenerator(generatorOptions);
        mapFragment = generator.GenerateFragment(2048, 2048, x, y);

        map.Add((x, y), mapFragment);

        return mapFragment;
    }
}