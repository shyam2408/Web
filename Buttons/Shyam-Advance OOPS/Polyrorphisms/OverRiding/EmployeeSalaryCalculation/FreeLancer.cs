using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculation
{
    public class FreeLancer:PersonalInfo
    {
        //Property: ProfileID, Role, SalaryAmount, NoOfWorkingDays
        //Method : Virtual CalculateSalary method that calculate salary by NoOfWorkingDays*500
        public int ProfileID { get; set; }
        public string Role { get; set; }
        public double SalaryAmount { get; set; }
        public int NoOfWorkingDays { get; set; }
        public FreeLancer(){}
        public FreeLancer(string name,string fatherName,string gender,string qualification,int profileID,string role,int noOfWorkingDays):base(name,fatherName,gender,qualification)
        {
            ProfileID=profileID;
            Role=role;
            NoOfWorkingDays=noOfWorkingDays;
        }

        public virtual double CalculateSalary()
        {
            return NoOfWorkingDays*500;
        }
        public string DisplayFreeLancer()
        {
            return$"Name :{Name}\nFatherName :{FatherName}\nGender :{Gender}\nQualification :{Qualification}\nProfileID :{ProfileID}\nRole :{Role}\nSalary Amount :{CalculateSalary()}\nNumber of Days Worked :{NoOfWorkingDays}";
        }
    }
}