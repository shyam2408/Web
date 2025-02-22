using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionProgram;
class Program
{
    public static void Main(string[] args)
    {
        //create an object to call all the methods in operations class
        Operations operation=new();
        Operations.DefaultData();
        Operations.MainMenu();
    }
}