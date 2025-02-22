

using System;
using EmployeeSalary;

namespace EmployeeWorklog;

class Program
{
    public static void Main(string[] args)
    {
        Employee employ=new FullTimeEmployee();
        employ.UpdateInfo(2324,"jhf","male",9);
        employ.DisplaySalary(); 
        Employee employ1=new ParttimeEmployee();
        employ1.UpdateInfo(2324,"jhf","male",9);
        employ1.DisplaySalary(); 
    }
}