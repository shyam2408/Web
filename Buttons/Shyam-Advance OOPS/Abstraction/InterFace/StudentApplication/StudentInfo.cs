using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApplication
{
    public class StudentInfo:IInformation
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }

        public StudentInfo(int studentID,string name,string fatherName,string phone)
        {
            StudentID=studentID;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
        }
        public void DisplayData()
        {
            System.Console.WriteLine($"StudentID :{StudentID}\nName :{Name}\nFather Name :{FatherName}\nPhone :{Phone}");
        }
    }
}