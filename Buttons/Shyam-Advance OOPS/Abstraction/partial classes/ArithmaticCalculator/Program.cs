using System;
namespace ArithmaticCalculator;
class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator=new Calculator(10,5);
        System.Console.WriteLine(calculator.Addition());
        System.Console.WriteLine(calculator.Subtraction());
        System.Console.WriteLine(calculator.Sin(60));
        System.Console.WriteLine(calculator.Tan(30));
        System.Console.WriteLine(calculator.Cos(0));
    }
}