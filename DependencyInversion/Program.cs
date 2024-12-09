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

public class Relationships {
    private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

    public void AddParentAndChild(Person parent, Person child)
    {
        relations.Add((parent, Relationship.Parent, child));
        relations.Add((child, Relationship.Child, parent));
    }

    public List<(Person, Relationship, Person)> Relations => relations;
}

public class Research
{
    public Research(Relationships relationships)
    {
        var relations = relationships.Relations;
        foreach (var r in relations.Where(
            x => x.Item1.Name == "John" &&
            x.Item2 == Relationship.Parent
        ))
        {
            Console.WriteLine($"John has a child called {r.Item3.Name}");
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
