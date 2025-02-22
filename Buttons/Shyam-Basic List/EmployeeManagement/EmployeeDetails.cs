using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace EmployeeManagement
{
    public class EmployeeDetails
    {
        private static int _EID=1000;
        public string EID { get; set; }
        public string EName { get; set; }
        public String Role { get; set; }
        public WorkLocation Location { get; set; }
        public  string TName { get; set; }
        public DateTime DOJ { get; set; }
        public GenderDetails Gender { get; set; }
    
    
        public EmployeeDetails(string ename,string role,WorkLocation location,string Tname,DateTime doj,GenderDetails gender)
        {
            EID=$"SF{++_EID}";
            EName=ename;
            Role=role;
            Location=location;
            TName=Tname;
            DOJ=doj;
            Gender=gender;
        }

        public void CalculateSal(int leavesTaken,int month, int year)
        {
            int totalDays=DateTime.DaysInMonth(year,month);
            double sal=(totalDays-leavesTaken)*500;
            Console.WriteLine($"you are salary is {Math.Abs(sal)}");        
        }
    }
}