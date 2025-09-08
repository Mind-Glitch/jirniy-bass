namespace Simulation.Common.Math;

public struct Range
{
    public Range(float from, float to)
    {
        _from = from;
        _to = to;
    }

    private readonly float _from, _to;
    private float _value;

    public float Value
    {
        get => _value;
        set
        {
            if (value < _from)
                _value = _from;
            else if (value > _to)
                _value = _to;
            else _value = value;
        }
    }
}