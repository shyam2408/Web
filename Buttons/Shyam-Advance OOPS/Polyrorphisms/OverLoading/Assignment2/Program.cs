using System;
namespace Assignment2;
class Program
{
    public static void Main(string[]args)
    {
        Operations op=new Operations();
        System.Console.WriteLine(op.Display("shyam"));
        System.Console.WriteLine(op.Display("shyam","vijay"));
        System.Console.WriteLine(op.Display("shyam","vijay","ajith"));
        System.Console.WriteLine(op.Display("Shyam",07));
        System.Console.WriteLine(op.Display("Vijay",99,"Ajith"));
    }
}
