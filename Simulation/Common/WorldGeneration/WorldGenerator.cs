using Simulation.Common.World;
using Simulation.Common.WorldGeneration.SoftSurfaceStage;

namespace Simulation.Common.WorldGeneration;

/// <summary>
/// Этот объект используется классом <see cref="Map"/> и не должен использоваться
/// напрямую, если вы не знаете точно что делаете.
/// </summary>
public class WorldGenerator
{
    public WorldGenerator(WorldGeneratorOptions options)
    {
        _options = options;
    }

    private readonly WorldGeneratorOptions _options;

    public MapPoint[,] GenerateFragment(int sizeX, int sizeZ, int worldXPos, int worldZPos)
    {
        var fragment = new MapPoint[sizeX, sizeZ];

        if (_options.SoftSurface)
        {
            var softSurfaceOptions = new SoftSurfaceGeneratorOptions
            {
                MaxHeight = 20,
                MinHeight = -20,
                GapBetweenPoints = 512
            };

            var generator = new SoftSurfaceGenerator(softSurfaceOptions);
            fragment = generator.CreateSurface(sizeX, sizeZ, worldXPos, worldZPos);
        }

        if (_options.Caves)
        {
            /* append to fragment */
        }

        if (_options.Queries)
        {
            /* append to fragment */
        }

        if (_options.Resources)
        {
            /* append to fragment */
        }

        /*todo: */
        return fragment;
    }
}