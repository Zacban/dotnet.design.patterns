namespace DesignPatterns.Abstract;

public interface IHotDrinkFactory
{
    IHotDrink Prepare(int amount);
}
