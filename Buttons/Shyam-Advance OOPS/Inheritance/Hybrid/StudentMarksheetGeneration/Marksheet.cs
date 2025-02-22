using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace StudentMarksheetGeneration
{
    public class Marksheet:TheoryExamMarks,ICalculate
    {
        //Class Marksheet: inherit TheoryExammarks, ICalculate
         //Properties: MarksheetNumber, DateOfIssue, Total, Percentage
         //Methods : SHowUGMarkSHeet
        private int s_marksheetNumber=0;
        public int ProjectMark { get; set; }
        public int MarksheetNumber { get; set; }

        public string DateOfIssue { get; set; }
        public double CalculateUGTotal()
        {
            double total=0;
            foreach(int i in Sem1)
            {
                total+=i;
            }
            foreach(int i in Sem2)
            {
                total+=i;
            }
            foreach(int i in Sem3)
            {
                total+=i;
            }
            return total;
        }
        public double CalculateUGPercentage()
        {
            return CalculateUGTotal()/24;
        }

        public Marksheet(int[] sem1,int[] sem2,int[] sem3,int[] sem4,int projectMark,string dateOfIssue):base(sem1,sem2,sem3,sem4)
        {
            MarksheetNumber=++s_marksheetNumber;
            ProjectMark=projectMark;
            DateOfIssue=dateOfIssue;
        }
        public string DisplayMarksheet()
        {
            return $"{DisplayExamMarks()}\nMarkSheet Number{MarksheetNumber}\nProject Mark :{ProjectMark}\nTotal :{CalculateUGTotal()}\nPercentage :{CalculateUGPercentage()}";
        }
    }
}