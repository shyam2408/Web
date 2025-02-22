using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SyncHotel
{
    public class FileHandler
    {
        static string folderName;
        public static void CreateFolder()
        {
            folderName = new Program().GetType().Namespace;
            //creating folder
            if (!Directory.Exists(folderName))
            {
                System.Console.WriteLine("Creating Folder..");
                Directory.CreateDirectory(folderName);
            }
        }

        public static void CreateFile(string fileName)
        {


            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }
        }

        public static void WriteToCSV(CustomList<Type> list)
        {
            CreateFolder();

            string fileName = $"{folderName}/{typeof(Type)}.csv";
            CreateFile(fileName);

            //get all properties from the list
            PropertyInfo[] property = typeof(Type).GetProperties();

            // for storing all row datas into this list to write into file
            List<string> fileData = new();

            foreach (Type data in list)
            {
                //list used for storing row of datas
                List<string> rowData = new();

                //used for fetching all properties and get them values
                foreach (PropertyInfo prop in property)
                {
                    if (prop.CanRead)
                    {
                        if (prop.PropertyType == typeof(DateTime))
                        {
                            DateTime date = (DateTime)prop.GetValue(data);
                            rowData.Add(date.ToString("dd/MM/yyyy") ?? "");
                        }
                        else
                        {
                            rowData.Add((prop.GetValue(data).ToString() ?? ""));
                        }
                    }
                }
                string row = string.Join(",", rowData);
                fileData.Add(row);
            }
            File.WriteAllLines(fileName, fileData);

        }

        public static void ReadFromCSV(CustomList<Type> list)
        {
            CreateFolder();

            string fileName = $"{folderName}/{typeof(Type)}.csv";
            CreateFile(fileName);

            //get all properties from the list
            PropertyInfo[] property = typeof(Type).GetProperties();

            string[] contents = File.ReadAllLines(fileName);

            foreach (string content in contents)
            {
                string[] values = content.Split(",");

                Type newObject = Activator.CreateInstance<Type>();

                for (int i = 0; i < values.Length; i++)
                {
                    if(values[i] != "")
                    {
                        if(property[i].PropertyType == typeof(DateTime))
                        {
                            property[i].SetValue(newObject, DateTime.ParseExact(values[i], "dd/MM/yyyy",null));
                        }
                        else if(property[i].PropertyType.IsEnum)
                        {
                            Enum.TryParse(property[i].PropertyType, values[i], true, out object data);
                            property[i].SetValue(newObject,data);
                        }
                        else
                        {
                            object data = Convert.ChangeType((object)values[i], property[i].PropertyType);
                            property[i].SetValue(newObject, data);
                        }
                    }
                }
                list.Add(newObject);
            }

        }

    }
}