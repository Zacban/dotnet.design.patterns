namespace DesignPatterns.Singleton;

public class Wall
{
    public Point Start { get; set; }
    public Point End { get; set; }
    public int Height { get; set; }

    public Wall(Point start, Point end)
    {
        Start = start;
        End = end;
        Height = BuildingContext.WallHeight;
    }
}

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}