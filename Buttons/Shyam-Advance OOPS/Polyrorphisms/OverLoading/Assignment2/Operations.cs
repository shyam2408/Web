using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Operations
    {
        
        public string Display(string value)
        {
            return $"Value: {value}";
        }
        public string Display(string value1,string value2)
        {
            return $"Value 1 :{value1}\nValue 2 :{value2}";
        }
        public string Display(string value1,string value2,string value3)
        {
            return $"Value 1 :{value1}\nValue 2 :{value2}\nValue 3 :{value3}";
        }
        public string Display(string value1,int value2)
        {
            return $"Value 1 :{value1}\nValue 2 :{value2}";
        }
        public string Display(string value1,int value2,string value3)
        {
            return $"Value 1 :{value1}\nValue 2 :{value2}\nValue 3 :{value3}";
        }


    }
}