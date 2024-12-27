using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns.Prototype.Inheritance;

public static class InheritanceProgram
{
    public static void Run(string[] args)
    {
        Console.WriteLine("== Protype Inheritance Example Start ==");
        var john = new Employee();
        john.Names = new[] { "John", "Doe" };
        john.Address = new Address {
            StreetName = "London Road",
            HouseNumber = 123
        };
        john.Salary = 321000;

        var copy = john.DeepCopy();
        Person p = john.DeepCopy();
        
        copy.Names[1] = "Smith";
        copy.Address.HouseNumber = 321;

        WriteLine(john);
        WriteLine(copy);
        WriteLine(p);
        Console.WriteLine("== Protype Inheritance Example End ==");
    }

}