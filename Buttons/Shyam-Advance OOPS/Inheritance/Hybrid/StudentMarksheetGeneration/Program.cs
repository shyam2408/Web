using System;

namespace StudentMarksheetGeneration;

class Program
{
    public static void Main(string[]args)
    {
        PersonalInfo person=new PersonalInfo("shyam","edison","9876543","sdfhjk","11/11/1111","male");
        TheoryExamMarks marks=new TheoryExamMarks([99,98,97,97,97,98],[99,98,96,97,97,98],[99,98,97,97,97,98],[99,98,98,97,97,98]);
        Marksheet marksheet=new Marksheet([99,98,97,97,97,98],[99,98,97,97,97,98],[99,98,97,97,97,98],[99,98,97,97,97,98],99,"24/08/2002");
        System.Console.WriteLine(person.DiplayPersonalInfo());
        System.Console.WriteLine(marks.DisplayExamMarks());
        System.Console.WriteLine(marksheet.DisplayMarksheet());
    }
}
