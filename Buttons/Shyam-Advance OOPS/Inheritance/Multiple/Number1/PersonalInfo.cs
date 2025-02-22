using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Number1
{
    public class PersonalInfo
    {
        private static int s_userID=0;
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Phone { get; set; }
        public MartialStatus MartialDetails { get; set; }
        public PersonalInfo(){}

        public PersonalInfo(string name,string gender,string dob, string phone, MartialStatus martialDetails)
        {
            UserID=++s_userID;
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            MartialDetails=martialDetails;
        }
        public PersonalInfo(int userID,string name,string gender,string dob, string phone, MartialStatus martialDetails)
        {
            UserID=userID;
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            MartialDetails=martialDetails;
        }
        public string DiplayPersonalInfo()
        {
            return $"UserID :{UserID}\nName :{Name}\nPhone :{Phone}\nDOB :{DOB}\nGender :{Gender}\nMartial Status :{MartialDetails}";
        }
        
    }
}