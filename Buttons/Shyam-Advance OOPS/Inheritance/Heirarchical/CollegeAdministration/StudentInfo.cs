using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_studentID = 0;
        public int StudentID { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public string Semester { get; set; }

        public StudentInfo(string name, string fatherName, string dob, string phone, string gender, string mail, string degree, string department, string semester) : base(name, fatherName, dob, phone, gender, mail)
        {
            StudentID = ++s_studentID;
            Department = department;
            Semester = semester;
        }
        public string DisplayStudentInfo()
        {
            return $"{DisplayPersonalInfo()}\nStudentID :{StudentID}\nDepartment :{Department}\nSemester :{Semester}";
        }
    }
}