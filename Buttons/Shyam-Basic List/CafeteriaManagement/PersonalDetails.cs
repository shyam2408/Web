using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class PersonalDetails
    {
        public string CustomerName { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public GenderDetails Gender { get; set; }
        public PersonalDetails() { }
        public PersonalDetails(string name, string fatherName, string phone, string mail,DateTime dob, GenderDetails gender)
        {
            
            CustomerName = name;
            FatherName = fatherName;
            Phone = phone;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
       
     //   public string DiplayPersonalInfo()
        //{
         //   return $"UserID :{UserID}\nName :{Name}\nFatherName :{FatherName}\nPhone :{Phone}\nMail :{Mail}\nDOB :{DOB}\nGender :{Gender}";
        //}
    }
}