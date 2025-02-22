using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public sealed class EmployeeInfo
    {
        public string EmployeeName { get; set; }
        
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public EmployeeInfo() { }
        public EmployeeInfo(string name, string fatherName, string phone, string mail, string dob, string gender)
        {
            EmployeeName = name;
        
            Phone = phone;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
    }
}