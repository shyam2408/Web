using System;

namespace SalaryCalculation;

class Program
{
    public static void Main(string[] args)
    {
        Attendance month1=new Attendance(22,3,5);
        Attendance month2=new Attendance(24,3,5);
        Attendance month3=new Attendance(26,3,5);
        month1.CalculateSalary();
        month2.CalculateSalary();
        month3.CalculateSalary();
        Attendance total=month1+month2+month3;
        System.Console.WriteLine(total.CalculateSalary());

    }
}
