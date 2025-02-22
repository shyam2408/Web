using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class PersonalInfo
    {
        private static int s_userID = 0;
        public int UserID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public PersonalInfo() { }
        public PersonalInfo(string name, string fatherName, string phone, string mail, string dob, string gender)
        {
            UserID = ++s_userID;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
        public PersonalInfo(int userId, string name, string fatherName, string phone, string mail, string dob, string gender)
        {
            UserID = userId;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
        public string DiplayPersonalInfo()
        {
            return $"UserID :{UserID}\nName :{Name}\nFatherName :{FatherName}\nPhone :{Phone}\nMail :{Mail}\nDOB :{DOB}\nGender :{Gender}";
        }
    }
}