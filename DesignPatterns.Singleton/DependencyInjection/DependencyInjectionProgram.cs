using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using DesignPatterns.Singleton.Basic;

namespace DesignPatterns.Singleton.DependencyInjection
{
    public static class DependencyInjectionProgram
    {
        public static void Run(string[] args)
        {
            var container = new ContainerBuilder();
            container.RegisterType<OrdinaryDatabase>().As<IDatabase>().SingleInstance();
            container.RegisterType<ConfigurableRecordFinder>();

            using (var c = container.Build())
            {
                var recordFinder = c.Resolve<ConfigurableRecordFinder>();
                var names = new[] { "Mexico City", "Nagoya" };
                int tp = recordFinder.TotalPopulation(names);
                Console.WriteLine($"Total population: {tp}");
            }
        }
    }
}