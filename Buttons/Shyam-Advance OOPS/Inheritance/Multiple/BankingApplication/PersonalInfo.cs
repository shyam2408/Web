using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPortal
{
    public class PersonalInfo
    {
        //Name, Gender, DOB, phone, mobile
        public string Name { get; set; }
        public string Phone { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public PersonalInfo() { }
        public PersonalInfo(string name, string phone, string dob, string gender)
        {
            Name = name;
            Phone = phone;
            DOB = dob;
            Gender = gender;
        }
        public string DiplayPersonalInfo()
        {
            return $"Name :{Name}\nPhone :{Phone}\nDOB :{DOB}\nGender :{Gender}";
        }
    }
}
