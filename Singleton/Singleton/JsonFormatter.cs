using System.Text.Json;

namespace Singleton;

public sealed class JsonFormatter
{
    private static readonly JsonFormatter _instance = new JsonFormatter();

    private JsonFormatter()
    {
        Console.WriteLine("Formatting data...");
    }

    public static JsonFormatter Instance
    {
        get { return _instance; }
    }

    public void Formatter(object obj)
    {
        string formattedJson = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine("JSON Formatted Output:");
        Console.WriteLine(formattedJson);
    }
}