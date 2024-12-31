using DesignPatterns.Singleton.Basic;
using DesignPatterns.Singleton.DependencyInjection;
using NUnit.Framework;

namespace DesignPatterns.Singleton;

static class Program
{
    static void Main(string[] args)
    {
        BasicProgram.Run(args);
        DependencyInjectionProgram.Run(args);
        ThreadSingletonProgram.Run(args);
    }
}

