using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculation
{
    public class PersonalInfo
    {
        //Name, FatherName,Gender,Qualification
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }
        public PersonalInfo(){}
        public PersonalInfo(string name,string fatherName,string gender,string qualification)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Qualification=qualification;
        }
    }
}