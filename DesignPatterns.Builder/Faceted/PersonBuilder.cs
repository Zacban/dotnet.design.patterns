using System.Runtime.CompilerServices;

namespace DesignPatterns.Builder.Faceted;

public class PersonBuilder // facade
{
    // reference!
    protected Person person = new();

    public PersonJobBuilder Works => new(person);
    public PersonAddressBuilder Lives => new(person);

    public static implicit operator Person(PersonBuilder pb) => pb.person;
}

public class PersonAddressBuilder : PersonBuilder
{
    public PersonAddressBuilder(Person person)
    {
        this.person = person;
    }

    public PersonAddressBuilder At(string streetAddress)
    {
        person.StreetAddress = streetAddress;
        return this;
    }

    public PersonAddressBuilder WithPostcode(string postcode)
    {
        person.Postcode = postcode;
        return this;
    }

    public PersonAddressBuilder In(string city)
    {
        person.City = city;
        return this;
    }
}
