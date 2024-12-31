using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Singleton.Basic;

namespace DesignPatterns.Singleton.DependencyInjection
{
    public class OrdinaryDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;

        public OrdinaryDatabase()
        {
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
    }
}