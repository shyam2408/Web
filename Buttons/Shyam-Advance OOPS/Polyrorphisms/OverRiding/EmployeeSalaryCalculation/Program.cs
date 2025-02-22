using System;

namespace EmployeeSalaryCalculation;

class Program
{
    public static void Main(string[]args)
    {
        FreeLancer lancer=new FreeLancer("shyam","edison","male","B.Tech",4040,"Developer",52);
        System.Console.WriteLine(lancer.DisplayFreeLancer());
        Syncfusion syncfusion=new Syncfusion("Vijay","Ajith","male","B.com",2334,"UIDesigner",28,"Kenya");
        System.Console.WriteLine(syncfusion.DisplaySync());
    }
}

