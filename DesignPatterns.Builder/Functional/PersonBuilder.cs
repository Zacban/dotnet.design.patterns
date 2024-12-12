namespace DesignPatterns.Builder.Functional;
public sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
{
    public PersonBuilder Called(string name) => Do(p => p.Name = name);
}

public static class PersonExtensions
{
    public static PersonBuilder WorksAs(this PersonBuilder builder, string position) => builder.Do(p => p.Position = position);
}
