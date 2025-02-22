using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public class SalaryInfo
    {
        private static int s_idCounter=100;
        public int SalaryID { get; set; }
        public double BasicSalary { get; set; }
        public string Month { get; set; }
        public SalaryInfo(){}
        public SalaryInfo(double basicSalary,string month)
        {
            SalaryID=++s_idCounter;
            BasicSalary=basicSalary;
            Month=month;
        }
        
    }
}