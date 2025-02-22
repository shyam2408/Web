using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalc
{
    public class SalaryInfo:PersonalInfo
    {
        //SalaryID, , Month
        private static int s_salaryID=0;
        public int SalaryID { get; set; }
    
        public int Month { get; set; }
        List<Attendance> attendances=new List<Attendance>();
        public SalaryInfo(){}

        public SalaryInfo(int month)
        {
            SalaryID=++s_salaryID;
            Month=month;
        }
        public SalaryInfo(int salaryID,int month)
        {
            SalaryID=salaryID;
            Month=month;
        }
        public void LogAttendance(Attendance attendance)
        {
            attendances.Add(attendance);
        }
        public double CalculateSalary()
        {
            double sum=0;
            foreach(Attendance attendance in attendances)
            {
                sum+=attendance.NumberOfHoursWorked;
            }
            sum/=8;
            double sal=sum*300;
            return sal;
        }
    }
}