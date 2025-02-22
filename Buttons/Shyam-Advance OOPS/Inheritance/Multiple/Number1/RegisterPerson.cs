using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Number1
{
    public class RegisterPerson:PersonalInfo,IFamilyInfo
    {
        private static int s_registrationID=0;
        public int RegistrationID { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSiblings { get; set; }
        public RegisterPerson(int userID,string name,string gender,string dob, string phone, MartialStatus martialDetails,DateTime registrationDate,string fatherName,string motherName,string houseAddress,int noOfSiblings):base(userID,name,gender,dob, phone, martialDetails)
        {
            RegistrationID=++s_registrationID;
            RegistrationDate=registrationDate;
            FatherName=fatherName;
            MotherName=motherName;
            HouseAddress=houseAddress;
            NoOfSiblings=noOfSiblings;
        }
        public string DisplayRegistor()
        {
            return $"{DiplayPersonalInfo()}\nRegistraionID :{RegistrationID}\nRegistration Date :{RegistrationDate.ToString("dd/MM/yyyy")}\nFather Name:{FatherName}\nMother Name :{MotherName}\nHouse Address :{HouseAddress}\nNO Of Siblings :{NoOfSiblings}";
        }
    }
}