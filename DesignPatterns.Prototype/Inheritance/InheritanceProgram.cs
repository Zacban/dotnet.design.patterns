using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns.Prototype.Inheritance;

public interface IDeepCopyable<T> 
{
    T DeepCopy();
}

public class Person : IDeepCopyable<Person>
{
    public string[] Names;
    public Address Address;

    public Person() { }
    public Person(string[] names, Address address)
    {
        Names = names;
        Address = address;
    }

    public virtual Person DeepCopy()
    {
        return new Person(Names.Clone() as string[], Address.DeepCopy());
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
    }
}

public class Employee : Person, IDeepCopyable<Employee> {
    public int Salary;

    public Employee() { }
    public Employee(string[] names, Address address, int salary) : base(names, address)
    {
        Salary = salary;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, {nameof(Salary)}: {Salary}";
    }

    public override Employee DeepCopy()
    {
        return new Employee(Names.Clone() as string[], Address.DeepCopy(), Salary);
    }
}
public class Address : IDeepCopyable<Address>
{
    public string StreetName;
    public int HouseNumber;

    public Address() { }
    public Address(string streetName, int houseNumber)
    {
        StreetName = streetName;
        HouseNumber = houseNumber;
    }

    public Address DeepCopy()
    {
        return (Address)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
    }
}

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
        
        copy.Names[1] = "Smith";
        copy.Address.HouseNumber = 321;

        WriteLine(john);
        WriteLine(copy);
        Console.WriteLine("== Protype Inheritance Example End ==");
    }

}