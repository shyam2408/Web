using System;
using StudentCounselling;

namespace StudenCounselling;

class Program
{
    public static void Main(string[] args)
    {
        PGCounselling counselling=new PGCounselling("shyam","Edison","987654567","987654567890",99,99,99,[99,99,99,99],[98,98,78,89],[78,99,99,88],[88,77,88,99]);
        System.Console.WriteLine(counselling.DisplayDetails());
        counselling.PayFees(500);
    }
}
