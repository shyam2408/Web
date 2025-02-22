using System;
namespace CafeteriaManagement;
class Program
{
    public static void Main(string[]args)
    {
        Operations op=new Operations();
        op.DefaultData();
        op.MainMenu();
    }
}
