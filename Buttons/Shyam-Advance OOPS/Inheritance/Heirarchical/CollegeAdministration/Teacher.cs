using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class TeacherInfo:PersonalInfo
    {
        private static int s_teacherID=0;
        public int TeacherID { get; set; }
        public string Department { get; set; }
        public string SubjectTeaching  { get; set; }
        public string Qualification { get; set; }
        public string YearOfExperience { get; set; }

        public TeacherInfo(string name, string fatherName, string dob, string phone, string gender, string mail,string department,string subjectTeaching,string qualification,string yearOfExperience):base(name,fatherName, dob,phone, gender, mail)
        {
            TeacherID=++s_teacherID;
            Department=department;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
        }
        public string DisplayTeacherInfo()
        {
            return $"{DisplayPersonalInfo()}\nTeacherID :{TeacherID}\nDepartment :{Department}\nSubject Teaching :{SubjectTeaching}\nQualification :{Qualification}\nYears of Experience :{YearOfExperience}";
        }

    }
}