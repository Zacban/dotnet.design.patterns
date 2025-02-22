namespace DesignPatterns.Singleton;

public sealed class PerThreadSingleton
{
    private static readonly ThreadLocal<PerThreadSingleton> threadInstance = new(() => new PerThreadSingleton());

    public static PerThreadSingleton Instance => threadInstance.Value ?? throw new InvalidOperationException("ThreadLocal is not initialized.");

    public int Id;
    private PerThreadSingleton()
    {
        Id = Thread.CurrentThread.ManagedThreadId;
    }
}
