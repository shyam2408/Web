using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace OnlineFoodDelivery
{
    public static class Grid<Type>
    {
        public static void PrintTables(CustomList<Type> list)
        {
            //storing property in the array
            PropertyInfo [] properties=typeof(Type).GetProperties();
            System.Console.WriteLine(new string('-',properties.Length*25));//printing the upper line of the table
            foreach(PropertyInfo property in properties)
            {
                System.Console.Write($"|{property.Name,-24}");//printing the table header
            }
            System.Console.Write("|\n");
            System.Console.WriteLine(new string('-',properties.Length*25));
            foreach(var info in list)
            {
                System.Console.WriteLine('|');
                foreach(PropertyInfo prop in properties)
                {
                    //checking if the properties can be readable
                    if(prop.CanRead)
                    {
                        //checking for the DateTime format
                        if(prop.GetValue(info).GetType().Equals(new DateTime().GetType()))
                        {
                            //handling DateTime
                            System.Console.Write($"|{((DateTime)prop.GetValue(info)).ToString("dd/MM/yyyy"),-23}|");
                        }
                        else//for all the other types
                        {
                            System.Console.Write($"|{prop.GetValue(info),-23}|");
                        }
                    }
                }
                System.Console.Write("|\n");
            }
            //printing lower line for the table
            System.Console.WriteLine(new string('-',properties.Length*25));
        }
    }
}