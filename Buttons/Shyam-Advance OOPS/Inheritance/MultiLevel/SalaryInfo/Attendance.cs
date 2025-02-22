using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalc
{
    public class Attendance
    {
        public string Date { get; set; }
        public double NumberOfHoursWorked { get; set; }
        public Attendance(){}
        public Attendance(string date,double numberOfHoursWorked)
        {
            Date=date;
            NumberOfHoursWorked=numberOfHoursWorked;
        }
    }
}