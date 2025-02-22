using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1
{
    public partial class EmployeeInfo
    {
        private static int s_idCounter=50000;

        public EmployeeInfo()
        {
            EmployeeID=++s_idCounter;
        }
    }
}