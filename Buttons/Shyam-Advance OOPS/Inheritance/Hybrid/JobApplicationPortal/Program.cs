using System;
using JobApplicationPortal;


namespace OnlineDTHRecharge
{
    class Program
    {
        public static void Main(string[] args)
        {
            RegisterApplication register1 = new RegisterApplication("Shyam", "edison", "987654345", "gmail.com", "11/11/1111", "male", "chennai", [99, 99, 99, 99], [77, 77, 77, 77], [78, 87, 98, 78], [77, 66, 99, 99], "CSE", "IT", 9, "computer");
            register1.DisplayApplication();

        }

    }
}
