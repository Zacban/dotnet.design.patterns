namespace DesignPatterns.Factory.Point;

public static class PointProgram
{
    public static void Run(string[] args)
    {
        Console.WriteLine("Point Program");
        var point = new Point(2, 3, CoordinateSystem.Cartesian);
        Console.WriteLine(point);
        var anotherPoint = new Point(2, 3, CoordinateSystem.Polar);
        Console.WriteLine(anotherPoint);
    }
}
