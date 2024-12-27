namespace DesignPatterns.Abstract;

internal class HotChocolateFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        Console.WriteLine($"Prepare {amount} ml of hot chocolate.");
        return new HotChocolate();
    }
}
