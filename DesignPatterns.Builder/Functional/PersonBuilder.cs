using static System.Console;

namespace DesignPatterns.Builder.Functional;
public sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
{
    public PersonBuilder Called(string name) => Do(p => p.Name = name);
}

public static class PersonExtensions
{
    public static PersonBuilder WorksAs(this PersonBuilder builder, string position) => builder.Do(p => p.Position = position);
}

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