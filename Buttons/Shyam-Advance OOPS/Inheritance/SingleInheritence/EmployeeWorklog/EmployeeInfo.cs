using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWorklog
{
    public class EmployeeInfo:SalaryInfo
    {
         private static int s_employeeID=0;
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string DOB { get; set; }
        public string Branch { get; set; }
        List<Attendance> attendances=new List<Attendance>();
        
        public EmployeeInfo(int salaryID,int month,string name,string fatherName,string gender,string mobile,string dob,string branch):base(salaryID,month)
        {
            EmployeeID=++s_employeeID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            Branch=branch;
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
            double sal=sum*500;
            return sal;
        }
        public string DisplayEmployee()
        {
            return $"EmployeeID :{EmployeeID}\nName :{Name}\nFatherName :{FatherName}\n/Gender :{Gender}\nMobile :{Mobile}\nDate of Birth :{DOB}\nBranch :{Branch}\nSalary :{CalculateSalary()}";
        }
    }
}