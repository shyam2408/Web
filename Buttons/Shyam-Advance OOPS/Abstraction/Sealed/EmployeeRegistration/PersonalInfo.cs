using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public PersonalInfo() { }
        public PersonalInfo(string name, string fatherName, string phone, string mail, string dob, string gender)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
    }
}