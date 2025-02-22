using System;
using System.Drawing;
using DrawingApplication;
namespace EmployeeSalary;
class Program
{
    public static void Main(string[]args)
    {
        Square square=new Square();
        System.Console.WriteLine(square.DrawShape());
        Line line=new Line();
        System.Console.WriteLine(line.DrawShape());
        Rectangles rectangle=new Rectangles();
        System.Console.WriteLine(rectangle.DrawShape());

    }
}
