using System;
namespace DrawingApplication;
class Program
{
    public static void Main(string[]args)
    {  
        Draw draw=new Draw();
        DrawPyramid pyramid=new DrawPyramid();
        DrawStar star=new DrawStar();
        System.Console.WriteLine(draw.DrawShape());
        System.Console.WriteLine(pyramid.DrawShape());
        System.Console.WriteLine(star.DrawShape());
    }
}
