using System;

namespace Calc;

class Program
{
    public static void Main(string[] args)
    {
        Cylinder cylinder=new Cylinder(7,9);
        cylinder.CalculateArea();
        cylinder.CalculateVolume();
        Cubes cubes=new Cubes(4);
        cubes.CalculateArea();
        cubes.CalculateVolume();
    }
}
