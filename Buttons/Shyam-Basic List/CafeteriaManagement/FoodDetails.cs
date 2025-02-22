using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class FoodDetails
    {
        private static int s_foodID=2000;
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        //c. QuantityAvailable PricePerQuantity
        public int QuantityAvailable { get; set; }
        public double PricePerQuantity { get; set; }
        public FoodDetails(string foodName,int quantityAvailable,double pricePerQuantity)
        {
            FoodID=$"FID{++s_foodID}";
            FoodName=foodName;
            QuantityAvailable=quantityAvailable;
            PricePerQuantity=pricePerQuantity;
        }
    }
}