using static System.Console;

namespace DesignPatterns.Prototype.Basic;

public static class BaseProgram {
    public static void Run(string[] args)
    {
        WriteLine("== Protype Basic Example Start ==");
        var john = new Person(new[] { "John", "Smith" }, new Address("London Road", 123));
        var jane = john.DeepCopy();
        jane.Names[0] = "Jane";
        jane.Address.HouseNumber = 321;

        WriteLine(jane);
        WriteLine(john);
        WriteLine("== Protype Basic Example End ==");
    }
}
