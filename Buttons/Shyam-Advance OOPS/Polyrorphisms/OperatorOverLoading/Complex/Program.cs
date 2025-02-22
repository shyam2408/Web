using System;

namespace Complex;

class Program
{
    public static void Main(string[] args)
    {
        ComplexNumbers number1=new ComplexNumbers(5,6);
        ComplexNumbers number2=new ComplexNumbers(3,4);
        ComplexNumbers addition=number1+number2;
        ComplexNumbers Subtraction=number1-number2;
        addition.Display();
        Subtraction.Display();
        System.Console.WriteLine(number1==number2);
        System.Console.WriteLine(number1>number2);
        System.Console.WriteLine(number1!=number2);
        System.Console.WriteLine(number1<number2);

    }
}
