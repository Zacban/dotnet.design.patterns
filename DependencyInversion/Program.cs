namespace DependencyInversion;

public enum Relationship
{
    Parent,
    Child,
    Sibling
}

public class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
}

public class Relationships : IRelationshipBrowser {
    private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

    public void AddParentAndChild(Person parent, Person child)
    {
        relations.Add((parent, Relationship.Parent, child));
        relations.Add((child, Relationship.Child, parent));
    }

    public IEnumerable<Person> FindAllChildrenOf(string name)
    {
        foreach (var r in relations.Where(
            x => x.Item1.Name == name &&
            x.Item2 == Relationship.Parent
        ))
        {
            yield return r.Item3;
        }
    }

    public List<(Person, Relationship, Person)> Relations => relations;
}

public interface IRelationshipBrowser
{
    IEnumerable<Person> FindAllChildrenOf(string name);
}

public class Research
{
    public Research(IRelationshipBrowser browser)
    {
        foreach (var p in browser.FindAllChildrenOf("John"))
        {
            Console.WriteLine($"John has a child called {p.Name}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var parent = new Person("John");
        var child1 = new Person("Chris");
        var child2 = new Person("Mary");

        var Relationships = new Relationships();
        Relationships.AddParentAndChild(parent, child1);
        Relationships.AddParentAndChild(parent, child2);

        var research = new Research(Relationships);
    }
}
