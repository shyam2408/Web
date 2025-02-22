using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class PersonalINFO
    {
        private static int s_userID=0;
        public string Name { get; set; }
        public int UserID { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public PersonalINFO(){}
        public PersonalINFO(string name,string fatherName,string phone,string mail,string dob,string gender)
        {
            UserID=++s_userID;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
        }
        public PersonalINFO(int userId,string name,string fatherName,string phone,string mail,string dob,string gender)
        {
            UserID=userId;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
        }
        public string DisplayPersonalInfo()
        {
            return $"UserID :{UserID}\nName :{Name}\nFatherName :{FatherName}\nPhone :{Phone}\nMail :{Mail}\nDOB :{DOB}\nGender :{Gender}";
        }
    }
}