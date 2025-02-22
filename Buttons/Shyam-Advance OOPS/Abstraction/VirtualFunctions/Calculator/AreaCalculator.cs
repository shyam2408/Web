using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Calculator
{
    public class AreaCalculator
    {
        public double Radius { get; set; }
        public AreaCalculator(){}
        public AreaCalculator(double radius)
        {
            Radius=radius;
        }
        public virtual double Calculate()
        {
            return 3.14*Radius*Radius;
        }
    }
}