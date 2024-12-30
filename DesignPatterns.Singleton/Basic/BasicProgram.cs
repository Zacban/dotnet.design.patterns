using System.Linq;

namespace DesignPatterns.Singleton.Basic;
public static class BasicProgram
{
    public static void Run(string[] args)
    {
        Console.WriteLine("Hello, BasicProgram!");
    }
}

public interface IDatabase {
    int GetPopulation(string name);
}

public class SingletonDatabase : IDatabase
{
    private Dictionary<string, int> capitals;

    // private SingletonDatabase()
    // {
    //     Console.WriteLine("Initializing database");

    //     capitals = File.ReadAllLines("capitals.txt")
    //         .Batch(2)
    //         .ToDictionary(
    //             list => list.ElementAt(0).Trim(),
    //             list => int.Parse(list.ElementAt(1))
    //         );
    // }

    public int GetPopulation(string name)
    {
        return capitals[name];
    }

    private static readonly Lazy<SingletonDatabase> instance =
        new(() => new SingletonDatabase());

    public static SingletonDatabase Instance => instance.Value;
}