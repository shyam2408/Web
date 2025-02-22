using System;
 
namespace SalaryCalculation;

class Program
{
    public static void Main(string[]args)
    {
        PermanentEmployee permanent=new PermanentEmployee(22000,"Febrarury");
        System.Console.WriteLine(permanent.DisplayPermanentEmployee());
        TemporaryEmployee temporary=new TemporaryEmployee(22000,"January");
        System.Console.WriteLine(temporary.DisplayPermanentEmployee());
    }
}