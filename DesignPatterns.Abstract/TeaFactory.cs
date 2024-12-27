using static System.Console;
namespace DesignPatterns.Abstract;

internal class TeaFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        WriteLine($"put in a tea bag, boil water, pour {amount} ml, add lemon, enjoy!");
        return new Tea();
    }
}
