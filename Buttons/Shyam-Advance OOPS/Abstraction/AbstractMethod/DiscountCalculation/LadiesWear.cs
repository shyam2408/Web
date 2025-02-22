using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountCalculation
{
    public class LadiesWear: Dress
    {
        public override int DressID { get; set; }
        public override string DressType { get; set; }
        public override string DressName { get; set; }
        public override double Price { get; set; }
        
        public override void UpdateDressInfo(int dressID,string dressName,string dressType,double price)
        {
            DressID=dressID;
            DressName=dressName;
            DressType=dressType;
            Price=price;
        }
        public override void DisplayBill()
        {
            System.Console.WriteLine($"Dress ID :{DressID}\nDress Name :{DressName}\nDress Type :{DressType}\n Price :{Price}");
        }
    }
}