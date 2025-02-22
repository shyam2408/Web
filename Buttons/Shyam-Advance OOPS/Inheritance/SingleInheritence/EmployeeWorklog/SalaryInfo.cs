using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWorklog
{
    public class SalaryInfo
    {
        //SalaryID, , Month
        private static int s_salaryID=0;
        public int SalaryID { get; set; }
    
        public int Month { get; set; }
        public SalaryInfo(){}

        public SalaryInfo(int month)
        {
            SalaryID=++s_salaryID;
            Month=month;
        }
        public SalaryInfo(int salaryID,int month)
        {
            SalaryID=salaryID;
            Month=month;
        }
    }
}