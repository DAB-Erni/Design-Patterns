namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        var employee = new
        {
            name = "Jane",
            age = 27,
            position = "Software Engineer",
            level = "Junior",
        };

        JsonFormatter.Instance.Formatter(employee);

        JsonFormatter jsonFormatter1 = JsonFormatter.Instance;
        JsonFormatter jsonFormatter2 = JsonFormatter.Instance;

        if (jsonFormatter1 == jsonFormatter2)
        {
            Console.WriteLine("Both formater instances are the same.");
        }
        else
        {
            Console.WriteLine("Formatter instances are different.");
        }

    }
}