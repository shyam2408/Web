using System;

namespace SyncHotel;

class Program
{
    public static void Main(string [] args)
    {
        Operations operation = new();

        operation.DefaultData();
        operation.MainMenu();
    }
}