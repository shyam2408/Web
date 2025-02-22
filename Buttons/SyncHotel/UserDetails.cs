using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHotel
{
    public class UserDetails : PersonalDetails, IWalletManager
    {
        /*
            User Registration Class inherits Personal Details, IWalletManager

            Field: _balance

            Properties:
            •	UserID (Auto Incremented – SF1000)
            •	WalletBalance

            Method: 
                WalletRecharge, DeductBalance

        */

        // Field
        private double _balance;
        private static int s_userID = 1000;
        private string _userID;

        //Properties:
        public string UserID { get{return _userID ; } set {_userID = value; s_userID = int.Parse(value.Remove(0,2)) ;} }
        public double WalletBalance { get{return _balance ;} set{_balance = value ;} }

        //Constructor
      //  public UserDetails(){}
        public UserDetails(string name, string mobileNumber, string aadharNumber, string email, string address, FoodType foodType, GenderDetails gender , double walletBalance) 
        : base(name, mobileNumber, aadharNumber, email, address, foodType, gender)
        {
            _userID = $"SF{++s_userID}";
            _balance = walletBalance;
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