namespace DesignPatterns.Factory.Point;

public static class PointProgram
{
    public static void Run(string[] args)
    {
        Console.WriteLine("Point Program");
        var point = Point.NewCartesianPoint(2, 3);
        Console.WriteLine(point);
        var anotherPoint = Point.NewPolarPoint(2, 3);
        Console.WriteLine(anotherPoint);
    }
}
