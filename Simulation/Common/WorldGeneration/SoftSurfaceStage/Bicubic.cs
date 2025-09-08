namespace Simulation.Common.WorldGeneration.SoftSurfaceStage;

internal static class Bicubic
{
    internal static float CatmullRom(float p0, float p1, float p2, float p3, float t)
    {
        float tSquare = t * t;
        float tCube = tSquare * t;

        return 0.5f * (
            2 * p1 +
            (-p0 + p2) * t +
            (2 * p0 - 5 * p1 + 4 * p2 - p3) * tSquare +
            (-p0 + 3 * p1 - 3 * p2 + p3) * tCube
        );
    }
}