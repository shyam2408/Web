using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel
{
    public class Car
    {
        public string FuelType { get; set; }
        public string Color { get; set; }
        public int NumberOfSeats { get; set; }
        public double TankCapacity { get; set; }
        public double NumberOfKmDriven { get; set; }

        public Car() { }

        public Car(string fuelType, string color, int numberOfSeats, double tankCapacity, double numberOfKmDriven)
        {
            FuelType = fuelType;
            Color = color;
            NumberOfSeats = numberOfSeats;
            TankCapacity = tankCapacity;
            NumberOfKmDriven = numberOfKmDriven;
        }
        public string DisplayCar()
        {
            return $"FuelType :{FuelType}\nColor :{Color}\nNumber Of Seats :{NumberOfSeats}\nTank Capacity :{TankCapacity}\nNumber of KM Driven :{NumberOfKmDriven}";
        }

    }
}