using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banks
{
    public class SBI:Bank
    {
        public override double GetInterest()
        {
            return 7.5;
        }
    }
}