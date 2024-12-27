using static System.Console;
namespace DesignPatterns.Abstract;

internal class Tea : IHotDrink
{
    public void Consume()
    {
        WriteLine("This tea is nice, but i'd prefer it with milk");
    }
}
