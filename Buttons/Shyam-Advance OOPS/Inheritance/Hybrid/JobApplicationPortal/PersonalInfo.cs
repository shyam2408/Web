using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPortal
{
    public class PersonalInfo:IFamilyInfo
    {
        //Name, Gender, DOB, phone, mobile

        public string Name { get; set; }
        public string FatherName { get; set; }
        public string PermanentAddress { get; set; }
        public string Phone { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public PersonalInfo() { }
        public PersonalInfo(string name, string fatherName, string phone, string mail, string dob, string gender,string permanentAddress)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            DOB = dob;
            Gender = gender;
            PermanentAddress=permanentAddress;
        }
        public string DiplayPersonalInfo()
        {
            return $"Name :{Name}\nFatherName :{FatherName}\nPhone :{Phone}\nDOB :{DOB}\nGender :{Gender}\nPermanent Address :{PermanentAddress}";
        }
    }
}
