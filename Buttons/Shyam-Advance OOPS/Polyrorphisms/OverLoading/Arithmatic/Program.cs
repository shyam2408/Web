using System;

namespace Arithmatic;

class Program
{
    public static void Main(string[]args)
    {
        ArithmaticOperations arithmatic=new ArithmaticOperations();
        System.Console.WriteLine(arithmatic.Multiply(4));
        System.Console.WriteLine(arithmatic.Multiply(4,2));
        System.Console.WriteLine(arithmatic.Multiply(4,4,2));
        System.Console.WriteLine(arithmatic.Multiply(4,2.0));
        System.Console.WriteLine(arithmatic.Multiply(4,2,2.0));

    }
}