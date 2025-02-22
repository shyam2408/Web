using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc
{
    public class Cylinder:Shape
    {
        private double area;
        private double volume;

        public override double Area { get{return area;}}
        public override double Volume { get{return volume;} }
        public double Radius { get; set; }
        public  double Height { get; set; }
        public  char Page { get; set; }='a';

        public Cylinder(double radius,double height)
        {
           
            Radius=radius;
            Height=height;
        }
        public override void CalculateArea()
        {
            area=2*3.14*Radius*(Radius+Height);
            System.Console.WriteLine("area :"+area);
        }
        public override void CalculateVolume()
        {
            volume=3.14*Math.Pow(Radius,2)+Height;
            System.Console.WriteLine("Volume :"+Volume);
        }
        
    }
}