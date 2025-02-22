using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalc
{
    public interface ITransaction
    {
        public double TotalAmount { get; set; }

        public double CalculateAmount();
        public void Displaybill();

    }
}