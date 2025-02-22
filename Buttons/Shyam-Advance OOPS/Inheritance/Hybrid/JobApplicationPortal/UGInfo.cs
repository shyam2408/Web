using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPortal
{
    public class UGInfo:PersonalInfo,ImarkDetails
    {
        public int[] Sem1 { get; set; }
        public int[] Sem2 { get; set; }
        public int[] Sem3 { get; set; }
        public int[] Sem4 { get; set; }
        //UGMarksheet Num, Degree, Branch, Sem1[], Sem2[], Sem3[], Sem4[] Marks
        private static int s_marksheetNum=0;
        public int UGMarksheetNum { get; set; }
        public string Degree { get; set; }
        public string Branch { get; set; }
        public UGInfo(){}

        public UGInfo(string name, string fatherName, string phone, string mail, string dob, string gender,string permanentAddress,int[] sem1,int[] sem2,int[] sem3,int[] sem4,string degree,string branch):base(name, fatherName, phone, mail, dob, gender,permanentAddress)
        {
            UGMarksheetNum=++s_marksheetNum;
            Degree=degree;
            Branch=branch;
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
        public bool CheckEligiblity()
        {
            double avg1=Sem1.Average();
            double avg2=Sem2.Average();
            double avg3=Sem3.Average();
            double avg4=Sem4.Average();
            return avg1>=75 && avg2>=75 && avg3>=75 && avg4>=75;
        }
        public string DiplayMarks()
        {
            return $"{DiplayPersonalInfo()}\nDegree :{Degree}\nBranch :{Branch}\nSEM! :{string.Join(",",Sem1)}\nSEM! :{string.Join(",",Sem2)}\nSEM! :{string.Join(",",Sem3)}\nSEM! :{string.Join(",",Sem4)}";
        }
    }
}