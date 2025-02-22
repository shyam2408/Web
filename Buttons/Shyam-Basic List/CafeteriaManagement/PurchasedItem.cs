using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class PurchasedItem
    {
        /*a. PurchaseID (Auto Increment – PRID5000)
         CartID     BookingID       FoodID
         PurchaseCoun     PriceOfPurchase*/
        private static int s_purchaseID=5000;
        public string PurchaseID { get; set; }
        public string BookingID { get; set; }
        public string CartID { get; set; }
        public string FoodID { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfPurchase { get; set; }
        public PurchasedItem(string bookingID,string cartID,string foodID,int purchaseCount,double priceOfPurchase)
        {
            PurchaseID=$"PRID{++s_purchaseID}";
            BookingID=bookingID;
            CartID=cartID;
            FoodID=foodID;
            PurchaseCount=purchaseCount;
            PriceOfPurchase=priceOfPurchase;
        }
    }
}