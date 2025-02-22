
using System;

namespace OnlineLibrary;

class Program
{
    public static void Main(string[] args)
    {
        DepartmentDetails department = new DepartmentDetails("CSE", "B.Tech");
        RackInfo rack = new RackInfo("IT", "B.CSE", 4);
        BookInfo book = new BookInfo("MECH", "B.Com", 8, 9, "Luthor", "Jake", 99);
        System.Console.WriteLine(department.DisplayDepartmentDetails());
        System.Console.WriteLine(rack.DisplayRackDetails());
        System.Console.WriteLine(book.DisplayBookInfo());
    }
}
