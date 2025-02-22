using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentDetails;

namespace SealedMethod1
{
    public class FamilyInfo:PersonInfo
    {
        
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int NoOfSib { get; set; }
        public string Native { get; set; }
        public FamilyInfo(){}

        public sealed override void Update(string name, string fatherName, string phone, string mail, string dob, string gender)
        {
            Update(name, fatherName, phone, mail, dob, gender);
        }
    }
}