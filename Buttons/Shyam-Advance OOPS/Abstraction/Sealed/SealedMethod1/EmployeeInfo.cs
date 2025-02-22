using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethod1
{
    public class EmployeeInfo:FamilyInfo
    {
        public int EmployeeID { get; set; }
        public string DateOFJoininng { get; set; }
        public override void Update(string name, string fatherName, string phone, string mail, string dob, string gender)
        {

        }

    }
}