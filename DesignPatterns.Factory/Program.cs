﻿using DesignPatterns.Factory.AsyncMethod;
using DesignPatterns.Factory.Factory;
using DesignPatterns.Factory.Point;

namespace DesignPatterns.Factory;

class Program
{
    static async Task Main(string[] args)
    {
        PointProgram.Run(args);
        await FooProgram.Run(args);
        FactoryProgram.Run(args);
    }
}
