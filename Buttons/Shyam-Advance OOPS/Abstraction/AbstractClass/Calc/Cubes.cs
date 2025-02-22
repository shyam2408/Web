using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc
{
    public class Cubes:Shape
    {
        private double area;
        private double volume;

        public override double Area { get{return area;}}
        public override double Volume { get{return volume;} }
        public double Radius { get; set; }
        public  double Height { get; set; }
        public  int Page { get; set; }='a';

        public Cubes(int page)
        {
           
            Page=page;
        }
        public override void CalculateArea()
        {
            area=6*Page*Page;
            System.Console.WriteLine("area :"+area);
        }
        public override void CalculateVolume()
        {
            volume=Page*Page*Page;
            System.Console.WriteLine("Volume :"+Volume);
        }
        
    }
}