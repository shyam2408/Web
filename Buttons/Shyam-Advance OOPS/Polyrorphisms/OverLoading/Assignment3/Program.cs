using System;

namespace Assignment3;

class Program
{
    public static void Main(string[]args)
    {
        Operations op=new Operations();
        System.Console.WriteLine(op.DisplayResult(5));
        System.Console.WriteLine(op.DisplayResult(9.1));
        System.Console.WriteLine(op.DisplayResult(9.55445));
        System.Console.WriteLine(op.DisplayResult(17));
    }
}