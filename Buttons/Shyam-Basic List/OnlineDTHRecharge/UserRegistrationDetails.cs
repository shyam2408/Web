using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineDTHRecharge
{
    public class UserRegistrationDetails
    {
        /// <summary>
        /// privately stores the wallet balance
        /// </summary>
        private double _walletBalance = 0;
        /// <summary>
        /// static field used to set the default value
        /// </summary> <summary>
        /// returns a integer
        /// </summary>
        private static int s_userID = 1000;
        /// </summary> <summary>
        /// userID is the string used to set username to this property
        /// </summary>
        /// <value>returns a string passed though the parameter</value>
        public string UserID { get; set; }
        /// <summary>
        /// /userNmae is the string used to set username to this property
        /// </summary> <summary>
        /// </summary>
        /// <value>returns a string passed though the parameter</value>
        public string UserName { get; set; }
        /// <summary>
        /// this is used to store string value in this peoperty
        /// </summary> <summary>
        /// </summary>
        /// <value>returns a string passed though the parameter</value>
        public string MobileNumber { get; set; }
        /// <summary>
        /// Enum to set the default value to the gender
        /// </summary> <summary>
        /// </summary>
        /// <value>returns default value only</value>
        public GenderDetails Gender { get; set; }
        /// <summary>
        /// this is used to store string value in this peoperty
        /// </summary>
        /// <value>returns a string passed though the parameter</value>
        public string EmailID { get; set; }
        /// <summary>
        /// used to set the balance int the customer wallet
        /// </summary>
        /// <value>returns a double value to the user</value>
        public double WalletBalance { get { return _walletBalance; } }

        /// <summary>
        /// constructor for this class
        /// </summary>
        /// <param name="userName">used to pass the string to the constructor</param>
        /// <param name="mobileNumber">used to pass the string to the constructor</param>
        /// <param name="gender">used to pass the string to the constructor</param>
        /// <param name="emailID">used to pass the string to the constructor</param>
        /// <param name="walletBalance">used to pass the Double to the constructor</param>
        public UserRegistrationDetails(string userName, string mobileNumber, GenderDetails gender, string emailID, double walletBalance)
        {
            UserID = $"UID{++s_userID}";
            UserName = userName;
            MobileNumber = mobileNumber;
            Gender = gender;
            EmailID = emailID;
            _walletBalance = walletBalance;
        }
        /// <summary>
        /// used to add amount to the walllet
        /// </summary>
        /// <param name="amount">int value paseed thoeurgh parameters</param>
        public void WalletRecharge(double amount)
        {
            _walletBalance += amount;
        }
        /// <summary>
        /// used to sub amount to the walllet
        /// </summary>
        /// <param name="amount">int value paseed thoeurgh parameters</param>
        public void DeductBalance(dynamic amount)
        {
            _walletBalance -= amount;
        }
    }
}