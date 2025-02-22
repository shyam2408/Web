
using System;

namespace EmployeeWorklog;

class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo(1000,8,"shyam","edison","male","876543456","11/11/1111","Eymard");
        Attendance attendance1=new Attendance("11/12/2024",8);
        Attendance attendance2=new Attendance("11/11/2024",10);
        Attendance attendance3=new Attendance("11/10/2024",10);
        Attendance attendance4=new Attendance("11/02/2024",10);
        Attendance attendance5=new Attendance("11/9/2024",10);
        employee.LogAttendance(attendance1);
        employee.LogAttendance(attendance2);
        employee.LogAttendance(attendance3);
        employee.LogAttendance(attendance4);
        employee.LogAttendance(attendance5);
        System.Console.WriteLine(employee.CalculateSalary());
        System.Console.WriteLine(employee.DisplayEmployee());
    }
}
