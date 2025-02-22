using System;

namespace LibraryManagement;

class Program
{
    public static void Main(string[]args)
    {
        EEEDepartment eEE=new EEEDepartment("shyam","OOPS","Vijay",2025);
        System.Console.WriteLine(eEE.UpdatebookInfo());
        CSEDepartment cSE=new CSEDepartment("Luthor","Marvel","Harry",2024);
        System.Console.WriteLine(cSE.UpdatebookInfo());
    }
}
