using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class PersonalInfo
    {

        private static int s_userID = 0;
        public string Name { get; set; }
        public int UserID { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public PersonalInfo() { }
        public PersonalInfo(string name, string fatherName, string dob, string phone, string gender, string mail)
        {
            UserID = ++s_userID;
            Name = name;
            FatherName = fatherName;
            DOB = dob;
            Phone = phone;
            Gender = gender;
            Mail = mail;
        }
        public string DisplayPersonalInfo()
        {
            return $"UserID :{UserID}\nName :{Name}\nFatherName :{FatherName}\nPhone :{Phone}\nMail :{Mail}\nDOB :{DOB}\nGender :{Gender}";
        }
    }
}