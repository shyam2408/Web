using System;
using Assignment_1;

namespace Assignment;

class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo();
        employee.UpdateEmployee("shyam","male","11/11/1111","2345675");
        employee.Display();
    }
}
