using System;
using Banks;

namespace Calc;

class Program
{
    public static void Main(string[] args)
    
    {
        Bank bank =new SBI();
        Console.WriteLine(bank.GetInterest());
        Bank bank1=new HDFC();
        System.Console.WriteLine(bank1.GetInterest());
        Bank bank2=new ICICI();
        System.Console.WriteLine(bank2.GetInterest());
        Bank bank3=new IDBI();
        System.Console.WriteLine(bank3.GetInterest());
    }
}
