namespace DesignPatterns.Builder.Functional;

public class Person {
    public string Name { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;

    public override string ToString() => $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
}