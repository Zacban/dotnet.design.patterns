using DesignPatterns.Prototype.Basic;
using DesignPatterns.Prototype.Inheritance;
using DesignPatterns.Prototype.SerializePrototype;

namespace DesignPatterns.Prototype;

class Program
{
    static void Main(string[] args)
    {
        BaseProgram.Run(args);
        InheritanceProgram.Run(args);
        SerializerProgram.Run(args);
    }
}


