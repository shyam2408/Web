using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle:Dimension
    {
        public double Lenght { get; set; }
        public double Height { get; set; }

        public Rectangle(int lenght,int height)
        {
            Lenght=lenght;
            Height=height;
        }
        public override double CalculateArea()
        {
            return Lenght*Height;
        }
    }
}