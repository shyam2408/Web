using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountCalculation
{
    public abstract class Dress
    {
        public abstract int DressID { get; set; }
        public abstract string DressType { get; set; }
        public abstract string DressName { get; set; }
        public abstract double Price { get; set; }

        public abstract void UpdateDressInfo(int dressID,string dressName,string dressType,double price);
        public abstract void DisplayBill();
    }
}