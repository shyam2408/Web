using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc
{
    public abstract class Shape
    {
        public abstract double Area { get;  }
        public abstract double Volume { get;  }
        public  double Radius { get; set; }
        public  double Height { get; set; }
        public  char Page { get; set; }

        public abstract void CalculateArea();
        public abstract void CalculateVolume();

        public void Display()
        {
            System.Console.WriteLine("Area :"+Area);
            System.Console.WriteLine("Volume :"+Volume);
        }


    }
}