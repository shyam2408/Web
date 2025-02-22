using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Two
{
    public partial class Student
    {
        public double total;
        public double percent;
        partial void CalculateTotal()
        {
            total =Physics+Chemistry+Maths;
            System.Console.WriteLine("Total :"+total);

        }
        partial void Percentage()
        {
            percent=total/300*100;
            System.Console.WriteLine("Percentage :"+percent);
        }
        partial void Update(string name,string gender,string dob,string mobile,int physics,int chemistry,int maths)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public void UpdateInfo(string name,string gender,string dob,string mobile,int physics,int chemistry,int maths)
        {
            Update( name, gender,dob,mobile,physics,chemistry,maths);
        }
        public void Percent()
        {
            Percentage();
        }
        public void Total()
        {
            CalculateTotal();
        }
        public string Display()
        {
            return $"Student :{StudentID}\nGender :{Gender}\nDOB :{DOB}\nMobile :{Mobile}\nPhysics :{Physics}\nChemistry :{Chemistry}\nMaths :{Maths}";
        }
    }
}