using System;


namespace Number1;

class Program
{
    public static void Main(string[]args)
    {
        PersonalInfo person = new PersonalInfo("shyam", " Male","24/08/2002", "9786231377",MartialStatus.Single);
        System.Console.WriteLine(person.DiplayPersonalInfo());
        RegisterPerson register=new RegisterPerson(123,"vijay","male","11/11/1111","9786231377",MartialStatus.Married,new DateTime(2002,08,22),"ajay","Setha","1/124,Chennai",5);
        System.Console.WriteLine(register.DisplayRegistor());
    }
}
