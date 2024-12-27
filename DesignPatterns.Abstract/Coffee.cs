using static System.Console;
namespace DesignPatterns.Abstract;

internal class Coffee : IHotDrink
{
    public void Consume()
    {
        WriteLine("This coffee is sensational!");
    }
}
