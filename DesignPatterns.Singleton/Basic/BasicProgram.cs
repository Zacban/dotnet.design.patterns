using System.Linq;
using MoreLinq;
using NUnit.Framework;

namespace DesignPatterns.Singleton.Basic;
public static class BasicProgram
{
    public static void Run(string[] args)
    {
        Console.WriteLine("Hello, BasicProgram!");
        var tokyo = SingletonDatabase.Instance.GetPopulation("Tokyo");
        Console.WriteLine($"Population of Tokyo is {tokyo}");
    }
}