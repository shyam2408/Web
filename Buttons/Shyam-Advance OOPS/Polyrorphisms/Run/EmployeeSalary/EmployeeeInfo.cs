using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class EmployeeeInfo:PersonalInfo
    {
        public int EmployeeID { get; set; }
        public string WorkLocation { get; set; }
        public EmployeeeInfo(){}
        public EmployeeeInfo(string name,string fatherName,string mobileNumber,string gender,int employeeID,string workLocation):base(name,fatherName, mobileNumber,gender)
        {
            EmployeeID=employeeID;
            WorkLocation=workLocation;
        }
        public override string Update()
        {
            return $"Employee ID : {EmployeeID}\nName : {Name}\nFathername : {FatherName}\nMobile Number : {MobileNumber}\nGender : {Gender}\nWorkLocation :{WorkLocation}";
        }
    }
}