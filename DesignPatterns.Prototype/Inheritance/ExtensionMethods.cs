namespace DesignPatterns.Prototype.Inheritance;

public static class ExtensionMethods
{
    public static T DeepCopy<T>(this IDeepCopyable<T> self) where T : new()
    {
        return self.DeepCopy();
    }

    public static T DeepCopy<T>(this T person) where T : Person, new()
    {
        return ((IDeepCopyable<T>)person).DeepCopy();
    }
}
