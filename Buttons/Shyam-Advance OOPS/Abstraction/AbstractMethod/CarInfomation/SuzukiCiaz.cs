using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfomation
{
    public class SuzukiCiaz:Car
    {
        public SuzukiCiaz()
        {
            Enginetype="Petrol";
            NoOfSeats=5;
            Price=500000;
            CarType="Hatchback";
        }
        public override string GetCarType()
        {
            return CarType;
        }
        public override string GetEngineType()
        {
            return Enginetype;
        }
        public override int GetNumberOfSeats()
        {
            return NoOfSeats;
        }
        public override double GetPrice()
        {
            return Price;
        }
    }
}