using System.Drawing;
using Simulation.Common.World;

namespace Simulation.Common.WorldGeneration;

public static class ImageGenerator
{
    public static void GenerateImage(Map map)
    {
        var frag = map.FindOrCreateChunk(0, 0);
        using Bitmap bmap = new Bitmap(2048, 2048);
        for (int i = 0; i < frag.GetLength(0); i++)
        for (int j = 0; j < frag.GetLength(1); j++)
        {
            var clr = ((frag[i, j].height + 40) / 80) * 255;
            var colorvalue = Convert.ToInt32(((frag[i, j].height + 40) / 80) * 255);
            
            bmap.SetPixel(i, j, Color.FromArgb(colorvalue, colorvalue, colorvalue));
        }
        
        bmap.Save("GeneratedImage.png");
    }
}