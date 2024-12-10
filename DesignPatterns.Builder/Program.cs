using System.Text;
using DesignPatterns.Builder.Generics;
using static System.Console;

namespace DesignPatterns.Builder;



class Program
{
    static void Main(string[] args)
    {
        var person = Person.New.Called("Dmitri").WorksAsA("Quant").Build();
        WriteLine(person);
    }
}
