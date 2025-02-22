using System;

namespace Two;
class Program
{
    public static void Main(string[] args)
    {
        Student student=new Student();
        student.UpdateInfo("shyam","male","24/02/2002","234543234",99,99,99);
        student.Total();
        System.Console.WriteLine(student.Display());
        student.Percent();

    }
}