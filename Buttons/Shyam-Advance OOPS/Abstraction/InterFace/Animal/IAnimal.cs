using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public string Habbit { get; set; }
        public string EatingHabbit { get; set; }
        
    }
}