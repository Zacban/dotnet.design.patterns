using System.Text;
using DesignPatterns.Builder.Faceted;
using DesignPatterns.Builder.Functional;
using DesignPatterns.Builder.Generics;
using DesignPatterns.Builder.Stepwise;
using static System.Console;

namespace DesignPatterns.Builder;



class Program
{
    static void Main(string[] args)
    {
        var person = Generics.Person.New.Called("Dmitri").WorksAsA("Quant").Build();
        WriteLine(person);

        var car = CarBuilder.Create().OfType(CarTypes.Sedan).WithWheelSize(18).Build();
        var car2 = CarBuilder.Create().OfType(CarTypes.SUV).WithWheelSize(24).Build();
        WriteLine(car);
        WriteLine(car2);

        FunctionalProgram.Run();
        FacetedProgram.Run();
    }
}
