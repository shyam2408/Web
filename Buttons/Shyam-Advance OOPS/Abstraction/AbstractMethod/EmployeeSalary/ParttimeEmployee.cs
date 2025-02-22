using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class ParttimeEmployee:Employee
    {
        public override int EmployeeID { get; set; }
        public override string Name { get; set; }
        public override string Gender { get; set; }
        public override int NumberOfWorked { get; set; }

        public override void UpdateInfo(int employeeID,string name,string gender,int numberOfWorked)
        {
            EmployeeID=employeeID;
            Name=name;
            Gender=gender;
            NumberOfWorked=numberOfWorked;
        }
        public override void DisplaySalary()
        {
            double sal=NumberOfWorked*400;
            System.Console.WriteLine("salary :"+sal);
        }
    }
}