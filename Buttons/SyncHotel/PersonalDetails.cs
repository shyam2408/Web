using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHotel
{
    public class PersonalDetails
    {
        /*
        Properties:
            •	UserName
            •	MobileNumber
            •	AadharNumber
            •	Email
            •	Address
            •	FoodType (Enum – Veg, NonVeg)
            •	Gender (Enum- Male, Female, Transgender)
        */
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string AadharNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public FoodType FoodType { get; set; }
        public GenderDetails Gender { get; set; }

        //Constructors
       // public PersonalDetails(){}
        public PersonalDetails(string name, string mobileNumber, string aadharNumber, string email, string address, FoodType foodType, GenderDetails gender)
        {
            Name = name;
            MobileNumber = mobileNumber; 
            AadharNumber = aadharNumber;
            Email = email;
            Address = address;
            FoodType = foodType;
            Gender = gender;
        }


    }
}