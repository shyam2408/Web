using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea:Maths
    {
        protected double radius;
        internal double area;
        public double Radius { get{return radius;} set{radius=value;} }
        public void CalculateCircleArea()
        {
            area=PI*radius*radius;
        }
        public void DisplayArea()
        {
            System.Console.WriteLine($"Circle Radius:{radius} Area :{area}");
        }
    }
}