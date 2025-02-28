namespace DesignPatterns.Prototype.Inheritance;

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

    public void CopyTo(Person target)
    {
        target.Names = Names.Clone() as string[];
        target.Address = Address.DeepCopy();
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
    }
}
