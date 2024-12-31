namespace DesignPatterns.Monostate;

class Program
{
    static void Main(string[] args)
    {
        var ceo = new CEO();
        ceo.Name = "Adam Smith";
        ceo.Age = 55;

        var ceo2 = new CEO();
        Console.WriteLine(ceo2);
    }
}
