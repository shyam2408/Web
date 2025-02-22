using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public abstract class Employee
    {
        public abstract int EmployeeID { get; set; }
        public abstract string Name { get; set; }
        public abstract string Gender { get; set; }
        public abstract int NumberOfWorked { get; set; }

        public abstract void UpdateInfo(int employeeID,string name,string gender,int numberOfWorked);
        public abstract void DisplaySalary();

    }
}