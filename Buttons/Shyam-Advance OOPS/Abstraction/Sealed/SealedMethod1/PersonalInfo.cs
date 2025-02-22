using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StudentDetails
{
    public  class PersonInfo
    {
       
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public PersonInfo() { }
        public virtual void Update(string name, string fatherName, string phone, string mail, string dob, string gender)
        {
           
            Name = name;
            Phone = phone;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
        
    }
}