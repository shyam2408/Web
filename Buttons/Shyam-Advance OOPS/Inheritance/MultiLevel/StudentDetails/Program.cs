using System;

namespace StudentDetails;

class Program
{
    public static void Main(string[]args)
    {
        PersonalINFO person=new PersonalINFO("shyam","edison","98765","shyam@gnmai.com","11/11/1111","male");
        System.Console.WriteLine(person.DisplayPersonalInfo());
        StudentInfo student=new StudentInfo(123,"shyam","vijay","9876345","ameil@gmaol;.vom","11/11/1111","male","12th","CSE","2024");
        System.Console.WriteLine(student.DiplayStudentInfo());
        HSCDetails hSC=new HSCDetails(123,"ajith","vijay","0987eret","Gmail.com","11/11/1111","male","12th","IT","2024",99,99,99);
        System.Console.WriteLine(hSC.DisplayHSCDetails());
    }
}
