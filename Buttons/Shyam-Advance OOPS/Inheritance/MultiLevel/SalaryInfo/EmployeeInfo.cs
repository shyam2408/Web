using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryInfo
{
    public class EmployeeInfo
    {
        private static int s_id=300;
        public int EmployeeID { get; set; }
        public string Branch { get; set; }
        public string Floor { get; set; }

        public EmployeeInfo(string branch,string floor)
        {
            EmployeeID=++s_id;
            Branch=branch;
            Floor=floor;
        }
        public string DisplayEmployee()
        {
            return $"EmployeeID :{EmployeeID}\nBranch :{Branch}\nFloor :{Floor}";
        }
    }
}