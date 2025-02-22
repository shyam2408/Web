using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Two
{
    public partial class Student
    {
        //StudentID,Name,Gender,DOB, Mobile, Physics, ,  Marks
        //Create partial methods - > CalculateTotal, Percentage and Update
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Mobile { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }

        partial void CalculateTotal();
        partial void Percentage();
        partial void Update(string name,string gender,string dob,string mobile,int physics,int chemistry,int maths);
    }
}