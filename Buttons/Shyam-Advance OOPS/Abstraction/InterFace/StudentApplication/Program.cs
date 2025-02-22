using System;
using StudentApplication;
namespace DrawingApplication;
class Program
{
    public static void Main(string[]args)
    { 
        StudentInfo student=new StudentInfo(101,"shyam","edison","0987654567");
        student.DisplayData();
        EmployeeInfo employee=new EmployeeInfo(678,"Vijay","Ajith");
        employee.DisplayData();
    }
}