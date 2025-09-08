namespace Simulation.Common.World;

public struct MapPoint
{
    public MapPoint()
    {
        
    }
    /*
     Это сущестует отдельным объектом, потому что можно будет указать Occupied by
     construction и дать туда ссылку ( int ). Это очень дёшиво будет по рантайму, потому 
     что не придётся итерировать сущности и искать по пересечению координат что там и где 
     стоит.
     */

    public float height;
    
    /* coords */
    public int x;
    public int z;

    public void SetHeight(float h)
    {
        height = h;
    }

    public void SubtractHeight(float h)
    {
        height -= h;
    }
}