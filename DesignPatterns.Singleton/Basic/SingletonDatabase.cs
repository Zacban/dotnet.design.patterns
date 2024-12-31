namespace DesignPatterns.Singleton.Basic;

public class SingletonDatabase : IDatabase
{
    private static int instanceCount; // 0
    public static int Count => instanceCount;
    private Dictionary<string, int> capitals;

    private SingletonDatabase()
    {
        instanceCount++;
        Console.WriteLine("Initializing database");

        capitals = File.ReadAllLines("capitals.txt")
            .Select(line => line.Split(','))
            .ToDictionary(
                line => line[0],
                line => int.Parse(line[1])
            );

            Console.WriteLine("There are {0} capitals in the database", capitals.Count);
    }

    public int GetPopulation(string name)
    {
        return capitals[name];
    }

    private static readonly Lazy<SingletonDatabase> instance =
        new(() => new SingletonDatabase());

    public static SingletonDatabase Instance => instance.Value;
}

public class SingletonRecordFinder
{
    public int TotalPopulation(IEnumerable<string> names)
    {
        int result = 0;
        foreach (var name in names)
        {
            result += SingletonDatabase.Instance.GetPopulation(name);
        }
        return result;
    }
}