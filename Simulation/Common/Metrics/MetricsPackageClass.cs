using System.Globalization;

namespace Simulation.Common.Metrics;

public class MetricsPackageClass
{
    private readonly Dictionary<string, string> _properties = [];

    protected void SetProperty<T>(ref T field, T value, string propertyKey)
        where T : notnull
    {
        field = value;
        _properties[propertyKey] = value.ToString() ?? "err";
    }


    public bool IsDirty => _properties.Count > 0;

    public void WriteDirtyProperties(Newtonsoft.Json.JsonWriter writer)
    {
        writer.WriteStartObject();
        foreach (var pair in _properties)
        {
            writer.WritePropertyName(pair.Key);
            writer.WriteValue(pair.Value);
        }

        writer.WriteEndObject();
        _properties.Clear();
    }
}