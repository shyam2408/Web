using System;

namespace CarModel;

class Program
{
    public static void Main(string[] args)
    {
        ShiftDezire shift = new ShiftDezire("pertrol", "black", 4, 5.5, 100, "Maruti", "super Model", 12345, 0293845);
        System.Console.WriteLine(shift.DisplayShift());
        ECO electricCar = new ECO("BATTERY", "White", 6, 7, 150, "TATa", "superFast", 09845, 0221343845);
        System.Console.WriteLine(electricCar.DisplayECO());
    }
}