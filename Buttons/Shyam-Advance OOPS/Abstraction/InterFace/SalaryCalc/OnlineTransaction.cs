using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalc
{
    public class OnlineTransaction:ITransaction
    {
        public double TotalAmount { get; set; }
        public int TransactionID { get; set; }
        public List<Purchase> purchases =new List<Purchase>();
        public string DateofPurchase { get; set; }

        public OnlineTransaction (int transactionID,string dateofPurchase)
        {
            TransactionID=transactionID;
            DateofPurchase=dateofPurchase;
        }
        public void LogPurchase(Purchase purchase)
        {
            purchases.Add(purchase);
        }
        public double CalculateAmount()
        {
            double total=0;
            foreach(Purchase purchase in purchases)
            {
                total+=purchase.Amount*purchase.Quantity;
            }
            return total;
        }

        public void Displaybill()
        {
            System.Console.WriteLine("The Total bill is "+CalculateAmount());
        }
    }
}