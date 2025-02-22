
using System;
using SalaryInfo;

namespace SalaryCalc;

class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person=new PersonalInfo("shyam","edison","male","876543456","11/11/1111");
        System.Console.WriteLine(person.DisplayPerson());
        EmployeeInfo employee=new EmployeeInfo("Kenya","1st");
        System.Console.WriteLine(employee.DisplayEmployee());
        SalaryInfo salary=new SalaryInfo(3000,10);
        Attendance attendance1=new Attendance("11/12/2024",8);
        Attendance attendance2=new Attendance("11/11/2024",10);
        Attendance attendance3=new Attendance("11/10/2024",10);
        Attendance attendance4=new Attendance("11/02/2024",10);
        Attendance attendance5=new Attendance("11/9/2024",10);
        salary.LogAttendance(attendance1);
        salary.LogAttendance(attendance2);
        salary.LogAttendance(attendance3);
        salary.LogAttendance(attendance4);
        salary.LogAttendance(attendance5);
        System.Console.WriteLine("Salary :"+salary.CalculateSalary());
    }
}
