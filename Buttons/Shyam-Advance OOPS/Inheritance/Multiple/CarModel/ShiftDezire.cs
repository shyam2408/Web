using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel
{
    public class ShiftDezire : Car, IBrand
    {
        /*Class ShiftDezire inherit Car, IBrandProperty:   , EngineNumber, ChasisNumber*/
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        private static int s_MakingID = 0;
        public int MakingID { get; set; }
        public double EngineNumber { get; set; }
        public double ChasisNumber { get; set; }

        public ShiftDezire(string fuelType, string color, int numberOfSeats, double tankCapacity, double numberOfKmDriven, string brandName, string modelName, double engineNumber, double chasisNumber) : base(fuelType, color, numberOfSeats, tankCapacity, numberOfKmDriven)
        {
            MakingID = ++s_MakingID;
            BrandName = brandName;
            ModelName = modelName;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
        }
        public string DisplayShift()
        {
            return $"MakingID :{MakingID}\n{DisplayCar()}\nBrandName :{BrandName}\nModelName :{ModelName}\nEngineNumber : {EngineNumber}\nChasisNumber :{ChasisNumber}";
        }
    }
}