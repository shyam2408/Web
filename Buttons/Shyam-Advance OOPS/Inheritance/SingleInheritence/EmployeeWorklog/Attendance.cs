using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWorklog
{
    public class Attendance
    {
        private static int s_DayID=3000;
        public int DayID { get; set; }
        public double NumberOfHoursWorked { get; set; }
        public Attendance(){}
        public Attendance(string date,double numberOfHoursWorked)
        {
            DayID=++s_DayID;
            NumberOfHoursWorked=numberOfHoursWorked;
        }
    }
}