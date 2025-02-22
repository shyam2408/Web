using System;
using DiscountCalculation;

namespace Dicount;

class Program
{
    public static void Main(string[]args)
    {
        Dress dress=new LadiesWear();
        dress.UpdateDressInfo(2345,"Jeans","leather",9874);
        dress.DisplayBill();
        Dress dress1=new MensWear();
        dress.UpdateDressInfo(25,"Saree","leather",984564);
        dress.DisplayBill();
    }
}