using System;

namespace StudentDetails;

class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person = new PersonalInfo("shyam", "edison", "9786231377", "shyamedison@gmail.com", "24/08/2002", " Male");
        System.Console.WriteLine(person.DiplayPersonalInfo());
        StudentInfo student = new StudentInfo(11,"MAN","Dad","123456789","syncfusion@gmail.com","11/11/1111","male", "12", "CS", "2024");
        System.Console.WriteLine(student.DiplayStudentInfo());
    }
}