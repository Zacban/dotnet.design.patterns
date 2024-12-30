namespace DesignPatterns.Factory.Factory
{
    public class FactoryProgram
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Factory Program");
            var factory = new TrackingThemeFactory();
            var theme = factory.CreateTheme(false);
            var theme2 = factory.CreateTheme(true);
            Console.WriteLine(factory.Info);

            var factory2 = new ReplaceableThemeFactory();
            var theme3 = factory2.CreateTheme(false);
            Console.WriteLine(theme3.Value.BgrColor);
            factory2.ReplaceTheme(true);
            Console.WriteLine(theme3.Value.BgrColor);
        }
    }
}