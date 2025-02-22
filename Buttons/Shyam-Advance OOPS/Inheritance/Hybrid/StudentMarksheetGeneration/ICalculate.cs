using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarksheetGeneration
{
    public interface ICalculate
    {
        public int ProjectMark { get; set; }

        public double CalculateUGTotal();
        public double CalculateUGPercentage();
    }
}