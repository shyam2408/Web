using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1
{
    public partial class EmployeeInfo
    {
        partial void Update(string name,string gender,string dob,string phone)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
        }
        public void UpdateEmployee(string name,string gender,string dob,string phone)
        {
            Update(name, gender,dob,phone);
        }
        public void Display()
        {
            System.Console.WriteLine($"Name:{Name}\nGender:{Gender}\nDate of Birth :{DOB}\nphone :{ Phone}");
        }
    }
}