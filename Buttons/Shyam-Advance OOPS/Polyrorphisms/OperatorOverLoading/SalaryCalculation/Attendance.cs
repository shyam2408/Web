using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public class Attendance
    {
        //TotalWorkingDaysInMonth, NumberOfLeavesTaken, NumberOfPermissionsTaken
        public int TotalWorkingDaysInMonth { get; set; }
        public int NumberOfLeavesTaken { get; set; }
        public int NumberOfPermissionsTaken { get; set; }
        public static Attendance operator +(Attendance month1,Attendance month2)
        {
            Attendance result=new Attendance(0,0,0);
            result.NumberOfLeavesTaken=month1.NumberOfLeavesTaken+month2.NumberOfLeavesTaken;
            result.NumberOfPermissionsTaken=month1.NumberOfPermissionsTaken+month2.NumberOfPermissionsTaken;
            result.TotalWorkingDaysInMonth=month1.TotalWorkingDaysInMonth+month2.TotalWorkingDaysInMonth;
            return result;
        }
        public Attendance(int totalWorkingDaysInMonth,int numberOfLeavesTaken,int numberOfPermissionsTaken)
        {
            TotalWorkingDaysInMonth=totalWorkingDaysInMonth;
            NumberOfLeavesTaken=numberOfLeavesTaken;
            NumberOfPermissionsTaken=numberOfPermissionsTaken;
        }
        public double CalculateSalary()
        {
            return (TotalWorkingDaysInMonth-NumberOfLeavesTaken-NumberOfPermissionsTaken)*500;
        }
    
    }
}