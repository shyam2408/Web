using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDetails
{
    public class Tata:CarInfo
    {
        private static int s_carModelNumber=5000;
        public int CarModelNumber { get; set; }
        public string CarModelName { get; set; }
        public Tata(double rcBookNumber,double engineNumber,int chasisNumber,string fuelType,  int numberOfSeats, double tankCapacity, double numberOfKmDriven,string carModelName):base(rcBookNumber,engineNumber,chasisNumber,fuelType,  numberOfSeats, tankCapacity,  numberOfKmDriven)
        {
            CarModelNumber=++s_carModelNumber;
            CarModelName=carModelName;
        }
        public string DisplayTata()
        {
            return $"CarModelNumber :{CarModelNumber}\nCarModelName :{CarModelName}\n{DisplayCar()}";
        }
    }
}