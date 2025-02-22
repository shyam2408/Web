using System;


namespace OnlineDTHRecharge
{
    class Program
    {
        public static void Main(string[]args)
        { //creating object for oberation class
            Operations operations = new Operations();
            //calling Dafault value
            operations.DefaultValue();
            //calling main menu
            operations.MainMenu();
        }
    }
}