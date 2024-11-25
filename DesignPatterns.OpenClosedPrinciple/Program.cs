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

    public static IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
    {
        foreach (var product in products)
        {
            if (product.Size == size && product.Color == color)
                yield return product;
        }
    }
}

public interface ISpecification<T>
{
    bool IsSatisfied(T t);
}

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}

public class ColorSpecification : ISpecification<Product>
{
    private Color _color;

    public ColorSpecification(Color color)
    {
        _color = color;
    }

    public bool IsSatisfied(Product t)
    {
        return t.Color == _color;
    }
}

public class SizeSpecification : ISpecification<Product>
{
    private Size _size;

    public SizeSpecification(Size size) => _size = size;

    public bool IsSatisfied(Product t)=>  t.Size == _size;
}

public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        foreach (var item in items)
        {
            if (spec.IsSatisfied(item))
                yield return item;
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

        var bf = new BetterFilter();
        Console.WriteLine("Green products (new):");
        foreach (var product in bf.Filter(products, new ColorSpecification(Color.Green)))
        {
            Console.WriteLine($" - {product.Name} is green");
        }
    }
}
