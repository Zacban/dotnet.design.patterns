namespace DesignPatterns.Builder.Functional;

public sealed class PersonBuilder
{
    private readonly List<Func<Person, Person>> actions = new();

    private PersonBuilder AddAction(Action<Person> action)
    {
        actions.Add(p => { action(p); return p; });
        return this;
    }

    public PersonBuilder Do(Action<Person> action) => AddAction(action);

    public PersonBuilder Called(string name) => Do(p => p.Name = name);

    public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));
}

public static class PersonExtensions
{
    public static PersonBuilder WorksAs(this PersonBuilder builder, string position) => builder.Do(p => p.Position = position);
}

public class Person {
    public string Name { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;

    public override string ToString() => $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
}