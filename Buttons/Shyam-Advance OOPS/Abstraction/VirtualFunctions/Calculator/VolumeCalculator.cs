using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class VolumeCalculator:AreaCalculator
    {
        public double Height { get; set; }

        public VolumeCalculator(double radius,double height):base(radius)
        {
            Height=height;
        }

        public override double Calculate()
        {
            return 3.14*Radius*Radius*Height;
        }
    }
}