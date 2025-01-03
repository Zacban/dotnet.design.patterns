namespace DesignPatterns.Abstract;

public class HotDrinkMachine
{
    public enum AvailableDrink { Coffee, Tea }
    private Dictionary<AvailableDrink, IHotDrinkFactory> factories = new Dictionary<AvailableDrink, IHotDrinkFactory>();

    public HotDrinkMachine() {
        foreach(AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink))) {
            var factory = (IHotDrinkFactory)Activator.CreateInstance(Type.GetType($"DesignPatterns.Abstract.{Enum.GetName(typeof(AvailableDrink), drink)}Factory"));
            factories.Add(drink, factory);
        }
    }

    public IHotDrink MakeDrink(AvailableDrink drink, int amount) {
        return factories[drink].Prepare(amount);
    }
}
