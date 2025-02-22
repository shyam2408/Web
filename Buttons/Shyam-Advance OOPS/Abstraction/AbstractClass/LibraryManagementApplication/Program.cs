using System;
using System.Data;
namespace LibraryManagementApplication;
class Program
{
    public static void Main(string[]args)
    {
        EEEDepartment eEE=new EEEDepartment("vihu","rith","hyla",2025);
        string set=eEE.SetBookInfo("shyam","LEX Luthor","chris evans",2024);
        string Update=eEE.UpdateBookInfo("shyam","LEX Luthor","chris evans",2024);
        System.Console.WriteLine(set);
        System.Console.WriteLine(Update);
    }
}
