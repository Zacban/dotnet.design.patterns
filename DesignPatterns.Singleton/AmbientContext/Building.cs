namespace DesignPatterns.Singleton;

public class Building
{
    public List<Wall> Walls { get; } = new();
}

public class BuildingContext
{
    public static int WallHeight { get; set; }
}
