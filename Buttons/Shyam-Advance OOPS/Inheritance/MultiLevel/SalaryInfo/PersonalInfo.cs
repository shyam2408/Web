using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalc
{
    public class PersonalInfo
    {
         private static int s_employeeID=0;
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string DOB { get; set; }
        
        public PersonalInfo(){}
        
        public PersonalInfo (string name,string fatherName,string gender,string mobile,string dob)
        {
            EmployeeID=++s_employeeID;
            Name=name;
            FatherName=fatherName;
            Gender=gender; 
            Mobile=mobile;
            DOB=dob;
        }
        
        public string DisplayPerson()
        {
            return $"EmployeeID :{EmployeeID}\nName :{Name}\nFatherName :{FatherName}\n/Gender :{Gender}\nMobile :{Mobile}\nDate of Birth :{DOB}";
        }
    }
}