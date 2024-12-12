using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Point;

public enum CoordinateSystem
{
    Cartesian,
    Polar
}

public class Point
{
    double x, y;

    /// <summary>
    /// Initializes a new instance of the <see cref="Point"/> class.
    /// </summary>
    /// <param name="a">x if cartesian, rho if polar</param>
    /// <param name="b">y if cartesian, theta is polar</param>
    /// <param name="system">The coordinate system to use. Cartesian if default</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Point(double a, double b, CoordinateSystem system = CoordinateSystem.Cartesian)
    {
        switch (system)
        {
            case CoordinateSystem.Cartesian:
                this.x = a;
                this.y = b;
                break;
            case CoordinateSystem.Polar:
                this.x = a * Math.Cos(b);
                this.y = a * Math.Sin(b);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(system), system, null);
        }
    }

    public override string ToString()
    {
        return $"x: {x}, y: {y}";
    }
}
