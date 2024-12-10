using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Generics;
public class Person
{
    public string Name { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;

    public class Builder : PersonJobBuilder<Builder> { }

    public static Builder New => new();

    public override string ToString() => $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
}

public class PersonBuilder {
    protected Person person = new();

    public Person Build() => person;
}

public class PersonInfoBuilder<SELF> : PersonBuilder 
where SELF : PersonInfoBuilder<SELF>
{
    public SELF Called(string name)
    {
        person.Name = name;
        return (SELF)this;
    }
}

public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>> 
where SELF : PersonJobBuilder<SELF>
{
    public SELF WorksAsA(string position)
    {
        person.Position = position;
        return (SELF)this;
    }
}