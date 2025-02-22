using System;
namespace SyncLibrary;
class Program
{
    public static void Main(string [] Args)
    {
        Operations operation=new Operations();
        //operation.DefaultData();
        operation.ReadFiles();
        operation.MainMenu();
        operation.WriteFiles();
    }
}