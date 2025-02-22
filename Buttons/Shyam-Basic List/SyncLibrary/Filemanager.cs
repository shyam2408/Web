using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace SyncLibrary
{
     public class Filemanager<Type>
    {
        public static void WriteToCSV(CustomList<Type> dataList)
        {
            string filePath = $"TestFolder/{typeof(Type).Name}.csv";
            if(!Directory.Exists("TestFolder"))
            {
                Directory.CreateDirectory("TestFolder");
            }
            if(!File.Exists(filePath))
            {
               File.Create(filePath).Close();
            }
            List<string> fileData = new List<string>();

            PropertyInfo [] names = typeof(Type).GetProperties();
            /*string header = string.Join(",", names.Select(x => x.Name));
            fileData.Add(header);    */

            foreach(Type info in dataList)
            {
                List<string> rowData = new List<string>();// row property formation list
                foreach(PropertyInfo prop in names)
                {
                    if(prop.GetIndexParameters().Length == 0)
                    {
                        if(!(prop.PropertyType.Name == " Datetime")) // Convert all other data types
                        {
                            rowData.Add(prop.GetValue(info).ToString()??""); //null optimization
                        }
                        else
                        {
                            DateTime date = (DateTime)prop.GetValue(info); // get data
                            rowData.Add(date.ToString("dd/MM/yyyy")); // format date to string
                        }
                    }
                }

                string row  = string.Join(",", rowData);
                fileData.Add(row);
            }
            File.WriteAllLines(filePath, fileData);
        }
        
        public static CustomList<Type> ReadFromCSV()
        {
            CustomList<Type> dataList = new CustomList<Type>(); 
            string filePath = $"TestFolder/{typeof(Type).Name}.csv";
            if(!Directory.Exists("TestFolder"))
            {
                Directory.CreateDirectory("TestFolder");
            }
            if(!File.Exists(filePath))
            {
               File.Create(filePath).Close();
            }

            if(File.Exists(filePath))
            {
                string[] fileData = File.ReadAllLines(filePath); // read file

                foreach(string line in fileData)
                {
                    if(line!= null && line.Trim() != "") // check file empty
                    {
                        string[]  values = line.Split(',');
                        if(values[0] != "")
                        {
                            Type info = Activator.CreateInstance<Type>(); // create new object for the generic type
                            dataList.Add(StringToObject(info, values));
                        }
                    }
                }
            }
            else
            {
                System.Console.WriteLine("File Doesn't exist");
            }

            return dataList;

        }

        private static Type StringToObject(Type info, string[] values)
        {
            PropertyInfo[] names = typeof(Type).GetProperties();
            for(int i = 0; i< names.Length ; i++)
            {
                PropertyInfo prop = names[i];
                if(prop.GetIndexParameters().Length == 0)
                {
                    if(prop.PropertyType == typeof(DateTime)) // datetime info
                    {
                        prop.SetValue(info,DateTime.ParseExact(values[i],"dd/MM/yyyy",null));
                    }
                    else if(prop.PropertyType.IsEnum) // Enumerated type
                    {
                        Enum.TryParse(prop.PropertyType, values[i], true, out object data);
                        prop.SetValue(info, data);
                    }
                    else // all other types
                    {
                        object data = Convert.ChangeType((object)values[i], prop.PropertyType);
                        prop.SetValue(info, data);
                    }
                }
            }
            return info;
        }
    }
}