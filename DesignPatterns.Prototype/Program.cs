using System.Net.Sockets;
using System.Security.AccessControl;
using static System.Console;

namespace DesignPatterns.Prototype;

public class Person
{
    public string[] Names;
    private Address Address;

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

public class Address
{
    public string StreetName;
    public int HouseNumber;

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

class Program
{
    static void Main(string[] args)
    {
        var john = new Person(new[] { "John", "Smith" }, new Address("London Road", 123));

        WriteLine(john);
    }
}


