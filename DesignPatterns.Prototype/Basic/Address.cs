namespace DesignPatterns.Prototype.Basic;

public class Address : IPrototype<Address>
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

    public Address DeepCopy()
    {
        return new Address(StreetName, HouseNumber);
    }
}