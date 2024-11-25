using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace DesignPatterns.OpenClosedPrinciple;

public enum Color { Red, Green, Blue }
public enum Size { Small, Medium, Large, Yuge }

public class Product
{
    public string Name;
    public Color Color;
    public Size Size;

    public Product(string name, Color color, Size size)
    {
        Name = name;
        Color = color;
        Size = size;
    }
}

public class ProductFilter
{
    public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    {
        foreach (var product in products)
        {
            if (product.Color == color)
                yield return product;
        }
    }

    public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    {
        foreach (var product in products)
        {
            if (product.Size == size)
                yield return product;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);

        Product[] products = { apple, tree, house };

        Console.WriteLine("Green products (old):");
        foreach(var product in ProductFilter.FilterByColor(products, Color.Green))
        {
            Console.WriteLine($" - {product.Name} is green");
        }
    }
}
