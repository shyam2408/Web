using System;

namespace MarkCalculation;

class Program
{
    public static void Main(string[]args)
    {
        Semester sem1=new Semester(99,99,99,89);
        Semester sem2=new Semester(98,78,98,08);
        sem1.CalculationMark();
        sem1.CalculatePercent();
        sem2.CalculationMark();
        sem2.CalculatePercent();
        
        System.Console.WriteLine(sem1.TotalMark);
        Semester total=sem1+sem2;
        System.Console.WriteLine(total.TotalMark);
        System.Console.WriteLine(total.Percentage);
    }
}