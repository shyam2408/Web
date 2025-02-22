using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using CalculatorApp;

namespace Encapsulation
{
    public class CylinderVolume:CircleArea
    {
        private double _height;
        internal double volume;
        public double Height { get{return _height;} set{_height=value;} }
        public void CalculateVolume()
        {
            CalculateCircleArea();
            volume=area*_height;
        }
        public void DisplayVolume()
        {
            System.Console.WriteLine($"Cyclinder Radius :{radius}\nHeight :{_height}\nVolume :{volume}");
        }
    }
}