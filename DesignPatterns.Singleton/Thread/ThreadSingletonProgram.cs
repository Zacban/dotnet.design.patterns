namespace DesignPatterns.Singleton;

public class ThreadSingletonProgram
{
    public static void Run(string[] args)
    {
        var thread1 = new Thread(() =>
        {
            var singleton = PerThreadSingleton.Instance;
            var singleton2 = PerThreadSingleton.Instance;
            Console.WriteLine($"Thread 1 instance1: {singleton.Id}");
            Console.WriteLine($"Thread 1 instance2: {singleton2.Id}");
        });

        var thread2 = new Thread(() =>
        {
            var singleton = PerThreadSingleton.Instance;
            Console.WriteLine($"Thread 2: {singleton.Id}");
        });

        thread1.Start();
        thread2.Start();
    }
}
