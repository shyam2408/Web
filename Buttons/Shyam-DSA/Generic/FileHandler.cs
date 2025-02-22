using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using SyncCET;

namespace SyncCET
{
      public class Filemanager<Type>
    {
        public static void WriteToCSV(CustomList<Type> dataList)
        {
            string filePath=$"TestFolder/{typeof(Type).Name}.CSV";
            if(!Directory.Exists("TestFolder"))
            {
                Directory.CreateDirectory("TestFolder");
            }
            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            List<string> fileData=new List<string>();//creating list named filedata to store CSV file

            PropertyInfo[] names=typeof(Type).GetProperties();
            //fileData.Add(header)
            foreach(Type info in dataList)
            {
                List<string> rowData=new List<string>();//row property formation list
                foreach(PropertyInfo prop in names)
                {
                    if(prop.GetIndexParameters().Length==0)
                    {
                        if(!(prop.PropertyType.Name=="DateTime"))
                        {
                            rowData.Add(prop.GetValue(info).ToString()??"");//convert all other data types except date time
                        }                                            //null colasion operator to handle null values
                        else
                        {
                            DateTime date=(DateTime)prop.GetValue(info);//get date
                            rowData.Add(date.ToString("dd/MM/yyyy"));//format date to string
                        }
                    }
                }
                string row=string.Join(",",rowData);
                fileData.Add(row);
            }
            File.WriteAllLines(filePath,fileData);//writing operation takes place on this place 
        }
        public static CustomList<Type> ReadFromCSV()
        {
        CustomList<Type> dataList=new CustomList<Type>();
            string filePath=$"TestFolder/{typeof(Type).Name}.CSV";
            if(!Directory.Exists("TestFolder"))
            {
                Directory.CreateDirectory("TestFolder");
            }
            if(File.Exists(filePath))
            {
                string [] fileData=File.ReadAllLines(filePath);//read file
                foreach(string Line in fileData)
                {
                    if(Line!=null && Line.Trim()!="")//check file empty
                    {
                        string[] values=Line.Split(",");
                        if(values[0] !="")
                        {
                            Type info=Activator.CreateInstance<Type>();//Create new object for generic type
                            dataList.Add(StringToObject(info,values));
                        }
                    }
                }
            }
            else
            {
                System.Console.WriteLine("File does not exists");
            }
            return dataList; 
        }
        public static Type StringToObject(Type info,string[] values)
        {
            PropertyInfo[] names=typeof(Type).GetProperties();
            for(int i =0;i<names.Length; i++)
            {
                PropertyInfo prop=names[i];
                if(prop.GetIndexParameters().Length==0)
                {
                    if(prop.PropertyType==typeof(DateTime))//datetime info
                    {
                        prop.SetValue(info,DateTime.ParseExact(values[i],"dd/MM/yyyy",null));
                    }
                    else if(prop.PropertyType.IsEnum)
                    {
                        //data=Enum.Parse<Type>(values[1],true);
                        Enum.TryParse(prop.PropertyType,values[i],true,out object data);
                        prop.SetValue(info,data);
                    }
                    else
                    {
                        object data=Convert.ChangeType((object)values[i],prop.PropertyType);
                        prop.SetValue(info,data);
                    }
                }
            }
            return info;
        }
    }
}