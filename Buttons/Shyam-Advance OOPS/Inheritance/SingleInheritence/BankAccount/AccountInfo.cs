using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public class AccountInfo : PersonalInfo
    {
        private double _balance;
        private static int s_accountID = 0;
        public int AccountID { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get { return _balance; } }

        public AccountInfo(int userId, string name, string fatherName, string phone, string mail, string dob, string gender, string branchName, string iFSCCode, double balance) : base(userId, name, fatherName, phone, mail, dob, gender)

        {
            AccountID = ++s_accountID;
            BranchName = branchName;
            IFSCCode = iFSCCode;
            _balance = balance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposited :{amount}\nNew Balance :{_balance}");
            }
            else
            {
                System.Console.WriteLine("Invalid Amount ");
            }
        }
        public void Withdraw(double amount)
        {
            if (_balance >= amount && _balance > 0)
            {
                _balance -= amount;
                System.Console.WriteLine($"Withdraw :{amount}\nNew Balance :{_balance}");
            }
            else
            {
                System.Console.WriteLine("Insufficient Balance ");
            }
        }
        public string AccountDetails()
        {
            return $"Account Number:{UserID}\n{DiplayPersonalInfo()}\nBranch Name :{BranchName}\nIFSC Code:{IFSCCode}\nBalance :{_balance}";
        }
    }
}