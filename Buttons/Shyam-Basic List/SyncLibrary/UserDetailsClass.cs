using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncLibrary
{
    public class UserDetailsClass
    {
        /*
        a.	CustomerID (Auto Increment – SF3000)
b.	UserName
c.	Gender
d.	Department – (Enum – Select, ECE, EEE, CSE)
e.	MobileNumber
f.	MailID
g.	WalletBalance

        */
        private static int s_customerID=3000;
        private string _customerID;
        public string CustomerID { get{return _customerID;} set{_customerID=value; s_customerID=Convert.ToInt32(value.Remove(0,2));} }
        public string UserName { get; set; }
        public GenderClassification Gender { get; set; }
        public string Department { get; set; }
        public long MobileNumber { get; set; }
        public string MailID { get; set; }
        private double _balance;
        public double WalletBalance{get{return _balance;} set{_balance=value;}}
        public UserDetailsClass(){}

        public UserDetailsClass(string userName,GenderClassification gender,string department,string mailID,long mobileNumber,double walletBalance)
        {
            _customerID=$"SF{++s_customerID}";
            UserName=userName;
            Gender=gender;
            Department=department;
            MailID=mailID;
            MobileNumber=mobileNumber;
            _balance=walletBalance;
        }

        public double WalletRecharge(double amount)
        {
                _balance+=amount;
                return _balance;
        }
        public double DeductBalance(double amount)
        {
                _balance-=amount;
                return _balance;
        }

    }
}