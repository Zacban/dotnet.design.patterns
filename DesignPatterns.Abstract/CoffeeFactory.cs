using static System.Console;
namespace DesignPatterns.Abstract;

internal class CoffeeFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        WriteLine($"Grind some beans, boil water, pour {amount} ml, add cream and sugar, enjoy!");
        return new Coffee();
    }
}
