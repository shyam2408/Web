using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1
{
    public partial class EmployeeInfo
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Phone { get; set; }
        partial void Update(string name,string gender,string dob,string phone);
    }
}