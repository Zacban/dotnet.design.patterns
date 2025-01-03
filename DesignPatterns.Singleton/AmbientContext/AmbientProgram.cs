﻿namespace DesignPatterns.Singleton;

public static class AmbientProgram
{
    public static void Run()
    {
        var house = new Building();

        // gnd 3000
        BuildingContext.WallHeight = 3000;
        house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0)));
        house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 5000)));

        // 1st 3500
        BuildingContext.WallHeight = 3500;
        house.Walls.Add(new Wall(new Point(0, 0), new Point(6000, 0)));
        house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));

        // gnd 3000
        BuildingContext.WallHeight = 3000;
        house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 4000)));
    }
}
