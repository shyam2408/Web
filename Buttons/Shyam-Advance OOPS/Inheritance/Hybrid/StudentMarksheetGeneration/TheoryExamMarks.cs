using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarksheetGeneration
{
    public class TheoryExamMarks
    {
        public int[] Sem1 { get; set; }
        public int[] Sem2 { get; set; }
        public int[] Sem3 { get; set; }
        public int[] Sem4 { get; set; }
        public TheoryExamMarks(){}
        public TheoryExamMarks(int[] sem1,int[] sem2,int[] sem3,int[] sem4)
        {
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
        public string DisplayExamMarks()
        {
            return $"Semester 1:{string.Join(",",Sem1)}\nSemester 1:{string.Join(",",Sem2)}\nSemester 1:{string.Join(",",Sem3)}\nSemester 1:{string.Join(",",Sem4)}\n";
        }
    }
}