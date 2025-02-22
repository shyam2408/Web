using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal
{
    public class Duck:IAnimal
    {
        public string Name { get; set; }
        public string Habbit { get; set; }
        public string EatingHabbit { get; set; }
        public Duck(string name,string habbit,string eatingHabbit)
        {
            Name=name;
            Habbit=habbit;
            EatingHabbit=eatingHabbit;
        }
        public void DisplayData()
        {
            System.Console.WriteLine($"Name :{Name}\nHabbit :{Habbit}\nEating Habbit :{EatingHabbit}");
        }
    }
}