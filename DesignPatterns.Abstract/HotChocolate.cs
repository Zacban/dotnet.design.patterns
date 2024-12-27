namespace DesignPatterns.Abstract;

internal class HotChocolate : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("Hot chocolate is is nice in these cold days.");
    }
}
