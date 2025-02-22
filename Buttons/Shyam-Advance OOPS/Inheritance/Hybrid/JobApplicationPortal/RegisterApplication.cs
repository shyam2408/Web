using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace JobApplicationPortal
{
    public class RegisterApplication:UGInfo
    {
        //RegisterNumber, Experience in Months, FieldOfIntrest
        private static int s_registerNumber=0;
        public int RegisterNumber { get; set; }
        public int ExperienceInMonth { get; set; }
        public string FieldOfIntrest { get; set; }
        public RegisterApplication(string name, string fatherName, string phone, string mail, string dob, string gender,string permanentAddress,int[] sem1,int[] sem2,int[] sem3,int[] sem4,string degree,string branch,int experienceInMonth,string fieldOfIntrest):base(name,  fatherName,  phone, mail, dob,  gender,permanentAddress,sem1,sem2, sem3,sem4, degree,branch)
        {
            RegisterNumber=++s_registerNumber;
            ExperienceInMonth=experienceInMonth;
            FieldOfIntrest=fieldOfIntrest;
        }
        
        public void DisplayApplication()
        {
            System.Console.WriteLine($"{DiplayMarks()}\nRegisterNumber :{RegisterNumber}\nExperience : {ExperienceInMonth}\nFeild of Interest :{FieldOfIntrest}");
            if(CheckEligiblity())
            {
                System.Console.WriteLine("you are eligible");
            }
            else { System.Console.WriteLine("you are not eligible");}
        }
    }
}