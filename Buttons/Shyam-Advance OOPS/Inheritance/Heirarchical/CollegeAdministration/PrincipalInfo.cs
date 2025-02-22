using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class PrincipalInfo : PersonalInfo
    {
        private static int s_principalID = 0;
        public int PrincipalID { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public string DateOfJoining { get; set; }

        public PrincipalInfo(string name, string fatherName, string dob, string phone, string gender, string mail, string qualification, int yearOfExperience, string dateOfJoining) : base(name, fatherName, dob, phone, gender, mail)
        {
            PrincipalID = ++s_principalID;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }
        public string DisplayPricipal()
        {
            return $"{DisplayPersonalInfo()}\nQualifiction :{Qualification}\nYear Of Experience :{YearOfExperience}\nDate of Joining :{DateOfJoining}";
        }
    }
}