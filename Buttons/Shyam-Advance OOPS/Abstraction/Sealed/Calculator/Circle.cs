using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class Circle:Calculator
    {
        public double Radius { get; set; }
        public Circle(double r)
        {
            Radius=r;
        }
        public sealed override void Area()
        {
            System.Console.WriteLine(3.14*Radius*Radius); 

        }
        public override void Volume()
        {
            System.Console.WriteLine("circle has no volume");
        }
    }
}