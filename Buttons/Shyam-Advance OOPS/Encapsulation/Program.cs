using System;
using Encapsulation;
using MathsLib;

namespace CalculatorApp
{
     class Progrram
    {
        public static void Main(string[]args)
        {
            Maths maths1=new Maths();
            System.Console.Write("weight :");
            System.Console.WriteLine(maths1.CalculateWeight(40));

            CircleArea circle=new CircleArea();
            circle.Radius=7;
            circle.CalculateCircleArea();
            circle.DisplayArea();

            CylinderVolume cylinder=new CylinderVolume();
            cylinder.Radius=9;
            cylinder.Height=8;
            cylinder.CalculateVolume();
            cylinder.DisplayVolume();
        }
    }
}
