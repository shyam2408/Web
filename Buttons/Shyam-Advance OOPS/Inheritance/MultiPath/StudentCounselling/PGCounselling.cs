using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCounselling
{
    public class PGCounselling:IHSCInfo,IUGInfo
    {
        private static int s_applicationID=1000;
        public int ApplicationID { get; set; }
        public bool FeeStatus { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string AadharNumber { get; set; }
         public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public double HSCPercentage { get; set; }
        public int[] Sem1 { get; set; }
        public int[] Sem2 { get; set; }
        public int[] Sem3 { get; set; }
        public int[] Sem4 { get; set; }
        public double UGPercentage { get; set; }
        public double CalculateUG()
        {
            double UGTotal=0;
            foreach(int mark in Sem1)
            {
                UGTotal+=mark;
            }
            foreach(int mark in Sem2)
            {
                UGTotal+=mark;
            }
            foreach(int mark in Sem3)
            {
                UGTotal+=mark;
            }
            foreach(int mark in Sem4)
            {
                UGTotal+=mark;
            }
            return Math.Round(UGTotal/16);
        }
        public double CalculateHSC()
        {
            double total=Physics+Chemistry+Maths;
            return Math.Round(total/3,1);
        }
        public PGCounselling(string name,string fatherName,string phone,string aadharNumber,int physics,int chemistry,int maths,int[] sem1,int[] sem2,int[] sem3,int[] sem4)
        {
            ApplicationID=++s_applicationID;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            AadharNumber=aadharNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
        public void PayFees(int amount)
        {
            if (amount==500)
            {
                FeeStatus=true;
                System.Console.WriteLine("fees Paid Successfully");
            }
            else
            {
                System.Console.WriteLine("Invalid amount");
            }
        }
        public string DisplayDetails()
        {
            return$"ApplicationID:{ApplicationID}\nName :{Name}\nFathername :{FatherName}\nPhone :{Phone}\nAadharNumber :{AadharNumber}\nPhysics :{Physics}\nChemistry :{Chemistry}\nMaths :{Maths}\nSem1 :{string.Join(",",Sem1)}\nSem2 :{string.Join(",",Sem1)}\nSem3 :{string.Join(",",Sem1)}\nSem4 :{string.Join(",",Sem1)}\nUGPercentage :{CalculateUG()}\nHSC Percentage :{CalculateHSC()}";
        }
    }
}