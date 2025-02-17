namespace DesignPatterns.Singleton;

public class Building
{
    public List<Wall> Walls { get; } = new();

    public override string ToString() => string.Join(Environment.NewLine, Walls);
}

public class BuildingContext : IDisposable
{
    public int WallHeight { get; set; }

    private static Stack<BuildingContext> _stack = new();

    static BuildingContext()
    {
        new BuildingContext(0);
    }

    public BuildingContext(int wallHeight)
    {
        WallHeight = wallHeight;
        _stack.Push(this);
    }

    public static BuildingContext Current => _stack.Peek();

    public void Dispose()
    {
        if (_stack.Count > 1)
        {
            _stack.Pop();
        }
    }
}
