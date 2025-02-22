using System;
namespace EmployeeSalary;
class Program
{
    public static void Main(string[]args)
    {
        PersonalInfo person=new EmployeeeInfo("shyam","edison","87654567","male",2343,"Kenya");
        System.Console.WriteLine(person.Update());
        SalaryInfo salary=new SalaryInfo("Ajay","Kannan","87654567","male",345643,"Tamilnadu",99);
        System.Console.WriteLine(salary.Update());
    }
}
