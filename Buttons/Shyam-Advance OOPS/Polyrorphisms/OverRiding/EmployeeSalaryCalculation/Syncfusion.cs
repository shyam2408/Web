using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculation
{
    public class Syncfusion:FreeLancer
    {
        private static int s_employeeID=1000;
        public int EmployeeID { get; set; }
        public string WorkLocation { get; set; }
        public Syncfusion(string name,string fatherName,string gender,string qualification,int profileID,string role,int noOfWorkingDays,string workLocation):base(name,fatherName,gender, qualification, profileID, role, noOfWorkingDays)
        {
            EmployeeID=++s_employeeID;
            WorkLocation=workLocation;
        }
        public override double CalculateSalary()
        {
            return NoOfWorkingDays*500;
        }
        public string DisplaySync()
        {
            return $"{DisplayFreeLancer()}\nEmployeeID :{EmployeeID}\nWorkLocation :{WorkLocation}";
        }
    }
}