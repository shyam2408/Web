using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalc
{
    public class Purchase
    {
        //Material ID, Name, Quantity, Amount
        public string MaterialID { get; set; }  
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
        public Purchase(string materialID,string name,int quantity,double amount)
        {
            MaterialID=materialID;
            Name=name;
            Quantity=quantity;
            Amount=amount;

        }

        
    }
}