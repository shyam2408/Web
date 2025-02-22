using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class CustomerDetails : PersonalDetails, IBalance
    {
        private static double _balance;
        private static int s_idCounter=1000;
        public double WalletBalance { get { return _balance; } }
        public string CustomerID { get; set; }
        public CustomerDetails(string name, string fatherName, string phone, string mail, DateTime dob, GenderDetails gender,double walletBalance) : base(name, fatherName, phone, mail, dob, gender)
        {
            CustomerID = $"CID{++s_idCounter}";
            _balance=walletBalance;
        }
        public void DeductBalance(double amount)
        {
            _balance -= amount;
        }
        public void WalletRecharge(double amount)
        {
            _balance += amount;
        }

    }
}