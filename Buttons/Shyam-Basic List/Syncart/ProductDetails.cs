using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syncart
{
    /// <summary>
    /// class for order Details
    /// </summary> <summary>
    /// <see cref="class ProductDetails"/> for the oreder details
    /// </summary>
    public class ProductDetails
    {
        /// <summary>
        /// private static field for product ID
        /// </summary>
        private static int s_productID = 2000;
        /// <summary>
        /// orderID will be stored
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string ProductID { get; set; }
        /// <summary>
        /// Prodeuctname will be stored
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public string ProductName { get; set; }
        /// <summary>
        /// orderID will be stored
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public int Stock { get; set; }
        /// <summary>
        /// stock will be stored
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public double Price { get; set; }
        /// <summary>
        /// price will be stored
        /// </summary>
        /// <value>rerturns a string to coresbonding value</value>
        public double ShippingDuration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productID">returns a string to coresbonding value</param>
        /// <param name="productName">returns a string to coresbonding value</param>
        /// <param name="stock">returns a int to coresbonding value</param>
        /// <param name="price">returns a integer to coresbonding value</param>
        /// <param name="shippingDuration">returns a string to coresbonding value</param> <summary>
        public ProductDetails(string productID, string productName, int stock, double price, double shippingDuration)
        {
            ProductID = $"PID{++s_productID}";
            ProductName = productName;
            Stock = stock;
            Price = price;
            ShippingDuration = shippingDuration;
        }
    }
}