using System;
using CarInfomation;

namespace Carinformation;

class Program
{
    public static void Main(string[]args)
    {
        
        Car Maruti=new MarutiSwift();
        Car Suzuki=new SuzukiCiaz();
        Maruti.DisplayCarDetails();
        Suzuki.DisplayCarDetails();
    }
}
