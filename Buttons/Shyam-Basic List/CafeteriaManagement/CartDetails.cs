using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class CartDetails
    {
        /*a. CartID (Auto Increment – CRID4000)
          CustomerID      FoodID
        PurchaseCount   PriceOfCart*/
        private static int s_cartID=4000;
        public string CartID { get; set; }
        public string CustomerID { get; set; }
        public string FoodID { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfCart { get; set; }
        public CartDetails(string customerID,string foodID,int purchaseCount,double priceOfCart)
        {
            CartID=$"CRID{++s_cartID}";
            CustomerID=customerID;
            FoodID=foodID;
            PurchaseCount=purchaseCount;
            PriceOfCart=priceOfCart;
        }
    }
}