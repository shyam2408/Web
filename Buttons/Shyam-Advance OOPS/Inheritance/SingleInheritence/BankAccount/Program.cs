using System;
using BankAccount;

namespace StudentDetails;

class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person = new PersonalInfo("shyam", "edison", "9786231377", "shyamedison@gmail.com", "24/08/2002", "Alpha Male");
        System.Console.WriteLine(person.DiplayPersonalInfo());
        AccountInfo account = new AccountInfo(1001, "Malaya", "Ajay", "12345678", "vijaymalaya@gmail.com", "11/11/1111", "male", "kanara", "KAN12345", 9990);
        System.Console.WriteLine(account.AccountDetails());
        account.Deposit(10000);
        account.Withdraw(100);
    }
}
