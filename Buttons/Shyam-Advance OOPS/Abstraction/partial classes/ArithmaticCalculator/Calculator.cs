using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArithmaticCalculator
{
    public partial class Calculator
    {
        public double FisrtValue { get; set; }
        public double SecondValue { get; set; }
        public Calculator(int fisrtValue,int secondValue)
        {
            FisrtValue=fisrtValue;
            SecondValue=secondValue;
        }

        public double Addition()
        {
            return FisrtValue+SecondValue;
        }
        public double Subtraction()
        {
            return FisrtValue-SecondValue;
        }
    }
}