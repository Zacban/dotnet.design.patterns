namespace DesignPatterns.Abstract;

class Program
{
    static void Main(string[] args)
    {
        var machine = new HotDrinkMachine();
        var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 100);
        drink.Consume();

        var drink2 = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Coffee, 240);
        drink2.Consume();

        var machine2 = new HotDrinkMachineV2();
        var drink3 = machine2.MakeDrink();
        drink3.Consume();
    }
}
