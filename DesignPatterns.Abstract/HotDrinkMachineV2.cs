namespace DesignPatterns.Abstract;

public class HotDrinkMachineV2 {
    private List<Tuple<string, IHotDrinkFactory>> factories = new List<Tuple<string, IHotDrinkFactory>>();

    public HotDrinkMachineV2() {
        foreach (var t in typeof(HotDrinkMachineV2).Assembly.GetTypes()) {
            if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface) {
                factories.Add(Tuple.Create(t.Name.Replace("Factory", string.Empty), (IHotDrinkFactory)Activator.CreateInstance(t)));
            }
        }
    }

    public IHotDrink MakeDrink() {
        Console.WriteLine("Available drinks:");
        for (var index = 0; index < factories.Count; index++) {
            var tuple = factories[index];
            Console.WriteLine($"{index}: {tuple.Item1}");
        }

        while (true) {
            string s;
            if ((s = Console.ReadLine()) != null && int.TryParse(s, out var i) && i >= 0 && i < factories.Count) {
                Console.Write("Specify amount: ");
                s = Console.ReadLine();
                if (s != null && int.TryParse(s, out var amount) && amount > 0) {
                    return factories[i].Item2.Prepare(amount);
                }
            }

            Console.WriteLine("Incorrect input, try again.");
        }
    }
}
