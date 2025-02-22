using System;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace ReadWriteTXT;
class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            System.Console.WriteLine("Creating Folder");
            Directory.CreateDirectory("TestFolder");
        }
        else
        {
            System.Console.WriteLine("Already Exists");
        }
        if(!File.Exists("TextFolder/MyFile1.txt"))
        {
            File.Create("TextFolder/MyFile1.txt").Close();
        }
        else
        {
            System.Console.WriteLine("File alredy exits");
        }
        System.Console.WriteLine("Select 1.Read 2. write");
        int option=Convert.ToInt32(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                StreamReader sr=new StreamReader("TextFolder/MyFile.txt");
                string data=sr.ReadLine();
                while(data!=null)
                {
                    System.Console.WriteLine(data);
                    data=sr.ReadLine();
                }
                sr.Close();
                break;
            }
            case 2:
            {
                string [] contents=File.ReadAllLines("TextFolder/MyFile1.txt");
                StreamWriter sw=new StreamWriter("TextFolder/MyFile1.txt");
                System.Console.WriteLine("entr to write");
                string data=Console.ReadLine();
                string old="";
                foreach(string line in contents)
                {
                    old=old+line+"\n";
                }
                old=old+data+"\n";
                sw.WriteLine(old);
                sw.Close();
                break;
            }
        }
    }
}