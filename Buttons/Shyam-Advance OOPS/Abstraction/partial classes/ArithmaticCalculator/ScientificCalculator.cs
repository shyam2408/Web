using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArithmaticCalculator
{
    public partial class Calculator
    {
        public double Sin(double degree)
        {
            return Math.Round(Math.Sin(degree*(3.14/180)));
        }
        public double Cos(double degree)
        {
            return Math.Round(Math.Cos(degree*(3.14/180)));
        }
        public double Tan(double degree)
        {
            return Math.Round(Math.Tan(degree*(3.14/180)));
        }
    }
}