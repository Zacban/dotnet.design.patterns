namespace DesignPatterns.LiskovSubstitution;

public class Rectangle {
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public Rectangle() {
    }

    public Rectangle(int width, int height) {
        Width = width;
        Height = height;
    }

    public override string ToString() {
        return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
    }
}

class Program
{
    static public int Area(Rectangle r) => r.Width * r.Height;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Rectangle rc = new Rectangle(2,3);

        Console.WriteLine($"{rc} has area {Area(rc)}");

    }
}
