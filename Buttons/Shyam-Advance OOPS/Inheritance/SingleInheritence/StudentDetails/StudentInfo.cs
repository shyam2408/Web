using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class StudentInfo : PersonalInfo
    {
        //Propeties: , Standard, , 
        private static int s_registrationID = 0;
        public int RegistrationID { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public string AcadamicYear { get; set; }

        public StudentInfo(int userId, string name, string fatherName, string phone, string mail, string dob, string gender, string standard, string branch, string acadamicYear) : base(userId, name, fatherName, phone, mail, dob, gender)
        {
            RegistrationID = ++s_registrationID;
            Standard = standard;
            Branch = branch;
            AcadamicYear = acadamicYear;
        }
        public string DiplayStudentInfo()
        {
            return $"RegistrationID :{RegistrationID}\n{DiplayPersonalInfo()}\nStandard :{Standard}\nBranch :{Branch}\nAcademicYear :{AcadamicYear}";
        }
    }
}