using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AsyncMethod;
public class Foo
{
    private Foo()
    {
        // private constructor
    }

    private async Task<Foo> InitAsync()
    {
        await Task.Delay(3000);
        return this;
    }

    public static Task<Foo> CreateAsync()
    {
        var result = new Foo();
        return result.InitAsync();
    }

    public override string ToString()
    {
        return "I am Foo";
    }
}

public static class FooProgram
{
    public static async Task Run(string[] args)
    {
        Console.WriteLine("Foo Program");
        var foo = await Foo.CreateAsync();
        Console.WriteLine(foo);
    }
}