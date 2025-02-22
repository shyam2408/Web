using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public class PermanentEmployee:SalaryInfo
    {
        private static int s_employeeID=1000;
        public int EmployeeID { get; set; }
        public EmployeeType Type { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double PF { get; set; }
        public double TotalSalary { get; set; }
        public  PermanentEmployee(double basicSalary,string month):base(basicSalary,month)
        {
            EmployeeID=++s_employeeID;
        }
        public double CaculateToatalSalary()
        {
            double total=BasicSalary+(BasicSalary*0.002)+(BasicSalary*0.0018)-(BasicSalary*0.0001);
            return Math.Round(total);
        }
        public string DisplayPermanentEmployee()
        {
            return $"Tmeporary Employee ID :{EmployeeID}\nSalaryID :{SalaryID}\nMonth :{Month}\nBasic Salary :{BasicSalary}\nDA :{BasicSalary*0.002}\nHRA :{BasicSalary*0.0018}\nPF :{BasicSalary*0.0001}\ntotal Salary :{CaculateToatalSalary()}";
        }
    }
}