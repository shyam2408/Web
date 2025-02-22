using System;
using Shapes;
namespace Calculator;
class Program
{
    public static void Main(string[]args)
    {  
        Dimension dimension=new Dimension(3,4);
        Sphere sphere=new Sphere(7);
        Rectangle rectangle=new Rectangle(7,8);
        System.Console.WriteLine(dimension.CalculateArea());
        System.Console.WriteLine(sphere.CalculateArea());
        System.Console.WriteLine(rectangle.CalculateArea());
    }
}
