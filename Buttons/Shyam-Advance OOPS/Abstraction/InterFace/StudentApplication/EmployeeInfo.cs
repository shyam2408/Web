using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApplication
{
    public class EmployeeInfo:IInformation
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }

        public EmployeeInfo(int employeeID,string name,string fatherName)
        {
            EmployeeID=employeeID;
            Name=name;
            FatherName=fatherName;
        }
        public void DisplayData()
        {
            System.Console.WriteLine($"StudentID :{EmployeeID}\nName :{Name}\nFather Name :{FatherName}");
        }
    }
}