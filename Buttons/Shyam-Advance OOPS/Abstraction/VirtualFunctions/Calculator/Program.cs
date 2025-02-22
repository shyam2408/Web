using System;
namespace Calculator;
class Program
{
    public static void Main(string[]args)
    {
        AreaCalculator area=new AreaCalculator(4.3);
        VolumeCalculator volume=new VolumeCalculator(8,5);
        System.Console.WriteLine(area.Calculate());
        System.Console.WriteLine(volume.Calculate());
    }
}
