namespace DesignPatterns.Factory.Factory
{
    public class DarkTheme : ITheme
    {
        public string TextColor => "White";
        public string BgrColor => "Dark Grey";
    }
}