using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syncart
{
    /// <summary>
    /// class for order Details
    /// </summary> <summary>
    /// <see cref="class CustomerClassDetails "/> for the oreder details
    /// </summary>
    public class CustomerClassDetails
    {
        /// <summary>
        /// private static field for product ID
        /// </summary>
        private static int s_customerID = 3000;
        /// <summary>
        /// orderID will be stored
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        private double _balance = 0;
        /// <summary>
        /// Prodeuctname will be stored
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string CustomerID { get; set; }
        /// <summary>
        /// Prodeuctname will be stored
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string CustomerName { get; set; }
        /// <summary>
        /// Prodeuctname will be stored
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string City { get; set; }
        /// <summary>
        /// Prodeuctname will be stored
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string MobileNumber { get; set; }
        /// <summary>
        /// Prodeuctname will be stored
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public double WalletBalance { get { return _balance; } }
        /// <summary>
        /// Prodeuctname will be stored
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string EmailID { get; set; }
        /// <summary>
        /// constructor for the class customerClass
        /// </summary>
        /// <param name="customerName">returns a string to coresbonding value</param>
        /// <param name="city">returns a string to coresbonding value</param>
        /// <param name="mobileNumber">returns a string to coresbonding value</param>
        /// <param name="walletBalance">returns a integer to coresbonding value</param>
        /// <param name="eMailID">returns a string to coresbonding value</param>
        public CustomerClassDetails(string customerName, string city, string mobileNumber, double walletBalance, string eMailID)
        {
            CustomerID = $"CID{++s_customerID}";
            CustomerName = customerName;
            City = city;
            MobileNumber = mobileNumber;
            _balance = walletBalance;
            EmailID = eMailID;
        }
        /// <summary>
        /// method for the walletrecharge
        /// </summary>
        /// <param name="amount">returns the double value to the user</param>
        public void WalletRecharge(double amount)
        {
            _balance += amount;
        }
        /// <summary>
        /// method to deduct balance
        /// </summary>
        /// <param name="amount">returns the double value to the user</param>
        public void DeductBalance(double amount)
        {
            _balance -= amount;
        }

    }

}