using static System.Console;
namespace DesignPatterns.Builder.Faceted;

public static class FacetedProgram {
    public static void Run()
    {
        var pb = new PersonBuilder();
        Person person = pb
            .Works
                .At("Fabrikam")
                .AsA("Engineer")
                .Earning(123000)
            .Lives
                .At("123 London Road")
                .In("London")
                .WithPostcode("SW12BC");

        WriteLine(person);
    }
}