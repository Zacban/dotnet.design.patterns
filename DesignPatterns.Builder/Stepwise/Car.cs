using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Stepwise;
public class Car
{
    public CarTypes CarType { get; set; }
    public int WheelSize { get; set; }

    public override string ToString()
    {
        return $"CarType: {CarType}, WheelSize: {WheelSize}";
    }
}
