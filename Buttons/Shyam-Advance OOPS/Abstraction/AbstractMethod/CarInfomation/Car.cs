using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfomation
{
    public abstract class Car
    {
        //Field: , , 
        //Properties:  -Petrol,diesel,cng, No.Of.Seats, Price, CarType -hatchback, sedan,  suv
        //Abstract methods: get engine type, get no. of seats, get price, get car type
        protected int Noofwheels=4;
        protected int NoOfDoors = 4;
        public string  Enginetype { get; set; }
        public int NoOfSeats{ get; set; }
        public double Price { get; set; }
        public string CarType { get; set; }
        public abstract string GetEngineType();
        public abstract int GetNumberOfSeats();
        public abstract double GetPrice();
        public abstract string GetCarType();
        public void DisplayCarDetails()
        {
            System.Console.WriteLine($"CarType :{GetCarType()}\nEngine Type :{GetEngineType()}\nNumber Of Seats :{GetNumberOfSeats()}\nPrice :{GetPrice()}");
        }
    }
}