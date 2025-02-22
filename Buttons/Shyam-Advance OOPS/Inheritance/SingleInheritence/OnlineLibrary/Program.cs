using System;

namespace OnlineLibrary;

class Program
{
    public static void Main(string[] args)
    {
        ClassDepartmentDetails class1 =new ClassDepartmentDetails("CSE","B.Tech");
        System.Console.WriteLine(class1.DisplayClassDetails());
        BookINFO book=new BookINFO(1001,"IT","B.Tech","Little Man","Jack Galagol",9999);
        System.Console.WriteLine(book.DisplayBookDetails());
    }
}