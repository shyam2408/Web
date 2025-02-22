using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class HSCDetails:StudentInfo
    {
        /*HSCMarksheetID, Physics, Chemistry, Maths, Total, Percentage marks*/
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public HSCDetails(int userId,string name,string fatherName,string phone,string mail,string dob,string gender,string standard ,string branch,string acadamicYear,int physics,int chemistry,int maths):base(userId,name,fatherName,phone,mail,dob,gender,standard , branch,acadamicYear)
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public double Total()
        {
            return Physics+Chemistry+Maths;
        }
        public double Percentage()
        {
            double Percent=Total()/300*100;
            return Percent;
        }
        public string DisplayHSCDetails()
        {
            return $"{DiplayStudentInfo()}\nChemistry :{Chemistry}\nPhysics :{Physics}\nMaths :{Maths}\nTotal :{Total()}\nPercentage :{Percentage()}";
        }
    }
}