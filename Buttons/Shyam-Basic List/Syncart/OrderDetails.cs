using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syncart
{
    /// <summary>
    /// class for order Details
    /// </summary> <summary>
    /// <see cref="class OrderDetails"/> for the oreder details
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// private static field for order ID
        /// </summary>
        private static int s_orderID = 1000;
        /// <summary>
        /// orderID will be stored
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string OrderID { get; set; }
        /// <summary>
        /// customerID is a string value
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string CustomerID { get; set; }
        /// <summary>
        /// customerID is a string value
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string ProductID { get; set; }
        /// <summary>
        /// customerID is a string value
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public double TotalPrice { get; set; }
        /// <summary>
        /// purchasedate is a string value
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>

        public DateTime PurchaseDate { get; set; }
        /// <summary>
        /// quantity is a string value
        /// </summary>
        /// <value>returns a string to coresbonding value</value>

        public int Quantity { get; set; }
        /// <summary>
        /// ordersstaus is a string value
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>

        public OrderStatus Status { get; set; }
        /// <summary>
        /// parametered constructer for the ordeDetails Class
        /// </summary>
        /// <param name="customerID">it is a string value type</param>
        /// <param name="productID">it is a string value type</param>
        /// <param name="totalPrice">it is a string value type</param>
        /// <param name="purchaseDate">it is a Datetime value type</param>
        /// <param name="quantity">it is a integer value type</param>
        /// <param name="status">it is a string value type</param> <summary>
        public OrderDetails(string customerID, string productID, double totalPrice, DateTime purchaseDate, int quantity, OrderStatus status)
        {
            OrderID = $"OID{++s_orderID}";
            CustomerID = customerID;
            ProductID = productID;
            TotalPrice = totalPrice;
            PurchaseDate = purchaseDate;
            Quantity = quantity;
            Status = status;
        }

    }
}