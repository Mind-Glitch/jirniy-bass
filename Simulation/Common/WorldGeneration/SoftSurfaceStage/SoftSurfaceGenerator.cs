using Simulation.Common.World;

namespace Simulation.Common.WorldGeneration.SoftSurfaceStage;

using CSMath = System.Math;

public class SoftSurfaceGenerator
{
    public SoftSurfaceGenerator(SoftSurfaceGeneratorOptions options)
    {
        _options = options;
    }

    private readonly SoftSurfaceGeneratorOptions _options;

    /// <summary>
    /// Проверяет есть ли x, y в пределах массива, и если есть, берёт от туда значение.
    /// Если нет, берёт из ближайшего существующего места. Ограничитель, короче, чтобы if
    /// не плодить.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    private float GetValueSafe(MapPoint[,] data, int x, int y)
    {
        int w = data.GetLength(0);
        int h = data.GetLength(1);

        x = CSMath.Max(0, CSMath.Min(w - 1, x));
        y = CSMath.Max(0, CSMath.Min(h - 1, y));

        return data[x, y].height;
    }

    public MapPoint[,] CreateSurface(int sizeX, int sizeZ, int worldXPos, int worldZPos)
    {
        return CreateWithBicubicCatmullRom(sizeX, sizeZ, worldXPos, worldZPos);
    }

    private MapPoint[,] CreateWithBicubicCatmullRom(
        int sizeX, int sizeZ, int worldXPos, int worldZPos)
    {
        MapPoint[,] result = new MapPoint[sizeX, sizeZ];

        /* Создаём опорные точки ( основные веса ) */
        for (int xPattern = 0; xPattern < sizeX; xPattern += _options.GapBetweenPoints)
        for (int zPattern = 0; zPattern < sizeZ; zPattern += _options.GapBetweenPoints)
            result[xPattern, zPattern].height = Random.Shared.NextSingle() *
                (_options.MaxHeight - _options.MinHeight) + _options.MinHeight;
        ;


        /* Сглаживаем по этим опорным точкам с помощью bicubicCatmullRom */
        for (int xPattern = 0; xPattern < sizeX; xPattern += _options.GapBetweenPoints)
        for (int zPattern = 0; zPattern < sizeZ; zPattern += _options.GapBetweenPoints)
        {
            for (int x = xPattern; x < xPattern + _options.GapBetweenPoints; x++)
            {
                float xLocal = (float) x - xPattern;

                float[] xCurve = new float[4];
                for (int i = 0; i < 4; i++)
                {
                    int calculatedZPattern = zPattern - _options.GapBetweenPoints +
                                             i * _options.GapBetweenPoints;

                    /*
                     z здесь одинаковая, сейчас я итерируюсь через зону сглаживания
                     по основным нагенерированным опорным точкам, в итоге создавая
                     поле 4x4.

                     ниже - первая четвёрка значений, с константным z ( то есть
                     точки  расположены в YZ пространстве ).
                     */
                    float p1 = GetValueSafe(result,
                        xPattern - _options.GapBetweenPoints,
                        calculatedZPattern);

                    float p2 = GetValueSafe(result,
                        xPattern,
                        calculatedZPattern);

                    float p3 = GetValueSafe(result,
                        xPattern + _options.GapBetweenPoints,
                        calculatedZPattern);

                    float p4 = GetValueSafe(result,
                        xPattern + 2 * _options.GapBetweenPoints,
                        calculatedZPattern);

                    /*
                     Для каждой строки этого поля я вычисляю кривую линию по
                     координате x, коскольку z везде была одинаковой выше
                     ( из оси X была создана линия ( Высоты X брались из опорных точек )
                     Но мне нужна локализованная позиция z, поскольку алгоритм
                     BicubicCatmullRom требует чтобы расстояние до точек
                     p1, p2, p3, p4 было одинаковым, а точка x должна находиться
                     в пределах этих p1, p2, p3, p4 значений ( то есть в пределах
                     кривой ), а так как моя кривая растягивается на фрагмент
                     xPattern -> xPattern + _options.GapBetweenPoints, я локализую
                     соответствующим образом мою координату x:
                     */

                    xCurve[i] = Bicubic.CatmullRom(
                        p1, p2, p3, p4,
                        xLocal / _options.GapBetweenPoints
                    );
                }

                for (int z = zPattern; z < zPattern + _options.GapBetweenPoints; z++)
                {
                    result[x, z].x = worldXPos + x;
                    result[x, z].z = worldZPos + z;

                    /* Это значения в пределах одного GapBetweenPoints */
                    float zLocal = (float) z - zPattern;

                    /* высота по х координате*/
                    var height = Bicubic.CatmullRom(
                        xCurve[0], xCurve[1], xCurve[2], xCurve[3],
                        zLocal / _options.GapBetweenPoints
                    );

                    if (height < _options.MinHeight)
                        height = _options.MinHeight;

                    if (height > _options.MaxHeight)
                        height = _options.MaxHeight;

                    result[x, z].height = height;
                }
            }
        }

        return result;
    }
    

}