using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Calculator
    {
        public double Radius { get; set; }
        public abstract void Area();
        public abstract void Volume();
        
    }
}