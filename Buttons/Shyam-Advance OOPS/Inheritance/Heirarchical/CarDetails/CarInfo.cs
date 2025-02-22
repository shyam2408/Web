using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDetails
{
    public class CarInfo
    {
        // //: RCBookNumber, EngineNumber, ChasisNumber, Milage, Tank Capacity, NumberOfSeats, NumberOfKmDriven, DateOfPurchase.
        // private double _mialge=0;
        public double RCBookNumber { get; set; }
        public double EngineNumber { get; set; }
        public double ChasisNumber { get; set; }
        public string FuelType { get; set; }
        public double Milage { get{return CalculateMilage();}  }
        public int NumberOfSeats { get; set; }
        public double TankCapacity { get; set; }
        public double NumberOfKmDriven { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public CarInfo() { }

        public CarInfo(double rcBookNumber,double engineNumber,int chasisNumber,string fuelType, int numberOfSeats, double tankCapacity, double numberOfKmDriven)
        {
            RCBookNumber=rcBookNumber;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            FuelType = fuelType;
            NumberOfSeats = numberOfSeats;
            TankCapacity = tankCapacity;
            NumberOfKmDriven = numberOfKmDriven;
        }
        public string DisplayCar()
        {
            return $"RCBoook Number :{RCBookNumber}\nEngine Number :{EngineNumber}\nChasis Number :{ChasisNumber}\nFuelType :{FuelType}\nNumber Of Seats :{NumberOfSeats}\nTank Capacity :{TankCapacity}\nNumber of KM Driven :{NumberOfKmDriven}\nMilage :{Milage}";
        }
        public double CalculateMilage()
        {
           return  Math.Round( NumberOfKmDriven/TankCapacity);
        }
    }
}