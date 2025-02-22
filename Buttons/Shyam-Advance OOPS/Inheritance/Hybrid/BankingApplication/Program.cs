using System;
using JobApplicationPortal;

namespace BankingApplication;

class Program
{
    public static void Main(string[]args)
    {
        PersonalInfo person=new PersonalInfo("shyam","98765345","11/11/1111","male");
        IDInfo iD=new IDInfo("Sahaya","98765","11/11/1111","male","VOD21","AAD123","PAN123");
        SavingAccount account=new SavingAccount("vijay","9876098","11/11/1111","male","VOD987","AAD098","PAN34567","savings","kanaraa","SDFGH*7654","chennai");
        account.Deposit(20000);
        account.Deposit(9);
        account.Withdraw(200);
        account.BalanceCheck();
        System.Console.WriteLine(person.DiplayPersonalInfo());
        System.Console.WriteLine(iD.DisplayInfo());
        System.Console.WriteLine(account.DisplayAccount());
    }
}