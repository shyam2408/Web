using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class SavingAccount : IDInfo, ICalculate, IBankInfo
    {
        private static int s_accountNumber = 1000;
        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        private double _balaance;
        public double Balance { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }
        public SavingAccount(string name, string phone, string dob, string gender, string voterID, string aadharID, string pANNumber, string accountType, string bankName, string iFSC, string branch) : base(name, phone, dob, gender, voterID, aadharID, pANNumber)
        {
            AccountNumber = ++s_accountNumber;
            AccountType = accountType;
            BankName = bankName;
            IFSC = iFSC;
            Branch = branch;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balaance += amount;
                System.Console.WriteLine($"{amount} is added new balance is {_balaance}");
            }
            else
            {
                System.Console.WriteLine("Invalid Amount");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount <= _balaance && amount > 0)
            {
                _balaance -= amount;
            }
            else
            {
                System.Console.WriteLine("Insufficient Balance or Invalid amount");
            }
        }
        public void BalanceCheck()
        {
            System.Console.WriteLine("Balance :" + _balaance);
        }

        public string DisplayAccount()
        {
            return $"{DisplayInfo()}\nAccount Number :{AccountNumber}\nAccount Type :{AccountType}\nBank name :{BankName}\nIFSC :{IFSC}\nBranch :{Branch}";
        }
    }
}