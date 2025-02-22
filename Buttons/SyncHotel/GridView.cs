using System;
using System.Collections.Generic;

using System.Reflection;


namespace SyncHotel
{
    public static class GridView<Type>
    {
        public static void PrintTables(CustomList<Type> list)
        {
            PropertyInfo[] property = typeof(Type).GetProperties();
            System.Console.WriteLine("----------------------------------------------------------------------------------------------");
            foreach(PropertyInfo prop in property)
            {
                if(prop.CanRead)
                {
                    System.Console.Write($"| {prop.Name, -15}");
                }
            }
            System.Console.Write("|\n");

            // for storing all row datas into this list to write into file
            List<string> fileData = new();

            foreach (Type data in list)
            {
                //used for fetching all properties and get them values
                foreach (PropertyInfo prop in property)
                {
                    if (prop.CanRead)
                    {
                        if (prop.PropertyType == typeof(DateTime))
                        {
                            DateTime date = (DateTime)prop.GetValue(data);
                            System.Console.Write($"| {date.ToString("dd/MM/yyyy") ?? "" , -15}" );
                        }
                        else
                        {
                            System.Console.Write($"| {prop.GetValue(data), -15}");
                        }
                    }
                }
                System.Console.Write("|\n");
                
            }
            System.Console.WriteLine("----------------------------------------------------------------------------------------------");
        }
    }
}