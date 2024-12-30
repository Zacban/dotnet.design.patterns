using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns.Prototype.SerializePrototype;

public static class ExtensionMethods
{
    public static T DeepCopy<T>(this T self)
    {
        var json = JsonSerializer.Serialize(self);
        WriteLine(json);
        var copy = JsonSerializer.Deserialize<T>(json);
        return copy;
    }
}

[Serializable]
public class Person
{
    public string[] Names { get; set; }
    public Address Address { get; set; }

    public Person() { }
    public Person(string[] names, Address address)
    {
        if (names == null)
            throw new ArgumentNullException(paramName: nameof(names));

        if (address == null)
            throw new ArgumentNullException(paramName: nameof(address));

        Names = names;
        Address = address;
    }

    public Person(Person other)
    {
        Names = other.Names;
        Address = new Address(other.Address);
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
    }
}

[Serializable]
public class Address
{
    public string StreetName { get; set; }
    public int HouseNumber { get; set; }

    public Address() { }
    public Address(string streetName, int houseNumber)
    {
        if (streetName == null)
            throw new ArgumentNullException(paramName: nameof(streetName));

        StreetName = streetName;
        this.HouseNumber = houseNumber;
    }

    public Address(Address other)
    {
        StreetName = other.StreetName;
        HouseNumber = other.HouseNumber;
    }

    public override string ToString()
    {
        return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
    }
}

public static class SerializerProgram
{
    public static void Run(string[] args)
    {
        Console.WriteLine("== Protype Serializer Example Start ==");
        var john = new Person(new[] { "John", "Smith" }, new Address("London Road", 123));
        var jane = john.DeepCopy();
        jane.Names[0] = "Jane";

        Console.WriteLine(john);
        Console.WriteLine(jane);
        Console.WriteLine("== Protype Serializer Example End ==");
    }

}
