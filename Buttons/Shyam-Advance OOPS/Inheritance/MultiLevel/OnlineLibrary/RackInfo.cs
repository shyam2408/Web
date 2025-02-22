using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class RackInfo : DepartmentDetails
    {
        private static int s_rackID = 0;
        public int RackID { get; set; }
        public int ColumnNumber { get; set; }
        public RackInfo() { }

        public RackInfo(string departmentName, string degree, int columnNumber) : base(departmentName, degree)
        {
            RackID = ++s_rackID;
            ColumnNumber = columnNumber;
        }
        public RackInfo(string departmentName, string degree, int rackID, int columnNumber) : base(departmentName, degree)
        {
            RackID = rackID;
            ColumnNumber = columnNumber;
        }
        public string DisplayRackDetails()
        {
            return $"{DisplayDepartmentDetails()}\nRackID :{RackID}\nColumn Number :{ColumnNumber}";
        }
    }
}