using static System.Console;

namespace DesignPatterns.Builder.Functional;

public static class FunctionalProgram
{
    public static void Run()
    {
        WriteLine("-- Functional Builder --");
        var person = new PersonBuilder()
            .Called("Zacban")
            .WorksAs("Programmer")
            .Build();

        WriteLine(person);
    }
}