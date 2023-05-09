namespace ApiProject.NameServices;

public class NameService
{
    private string[] Names { get; }
        = new[]
        {
            "John",
            "Jim",
            "Maria",
            "Yana",
        };

    private Random _random = new Random();

    public string GetRandomNames()
    {
        return Names[_random.Next(Names.Length)];
    }
}