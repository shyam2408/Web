using System;

namespace CarDetails;

class Program
{
    public static void Main(string[] args)
    {
        Tata safari=new Tata(2345,3456,2345,"petrol",6,20,300,"SUV");
        Suzuki maruti=new Suzuki(96855,32345,2743,"Diesel",4,30,300,"SUV");
        System.Console.WriteLine(safari.DisplayTata());
        System.Console.WriteLine(maruti.DisplaySuzuki());
        
    }
}