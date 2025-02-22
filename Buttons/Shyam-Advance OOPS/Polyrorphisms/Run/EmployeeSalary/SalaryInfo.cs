using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class SalaryInfo:EmployeeeInfo
    {
        private static int s_salaryID=400;
        public int SalaryID { get; set; }
        public int NumberOfDaysWorked { get; set; }
        public SalaryInfo(string name,string fatherName,string mobileNumber,string gender,int employeeID,string workLocation,int numberOfDaysWorked):base(name,fatherName, mobileNumber,gender,employeeID,workLocation)
        {
            SalaryID=++s_salaryID;
            NumberOfDaysWorked=numberOfDaysWorked;
        }
        public double CaculateSalary()
        {
            return NumberOfDaysWorked*500;
        }
        public override string Update()
        {
            return $"Employee ID : {EmployeeID}\nSalaryID:{SalaryID}\nName : {Name}\nFathername : {FatherName}\nMobile Number : {MobileNumber}\nGender : {Gender}\nWorkLocation :{WorkLocation}\nNumber Of Days Worked :{NumberOfDaysWorked}\nSalary :{CaculateSalary()}";
        }
    }
}