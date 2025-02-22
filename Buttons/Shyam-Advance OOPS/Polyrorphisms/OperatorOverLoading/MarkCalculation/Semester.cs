using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkCalculation
{
    public class Semester
    {
        private double _total;
        private double _percent;
        public int SubjectMark1 { get; set; }
        public int SubjectMark2 { get; set; }
        public int SubjectMark3 { get; set; }
        public int SubjectMark4 { get; set; }
        public double TotalMark { get{return _total;} }
        public double Percentage { get{return _percent;} }
        public Semester(int mark1,int mark2,int mark3,int mark4)
        {
            SubjectMark1=mark1;
            SubjectMark2=mark2;
            SubjectMark3=mark3;
            SubjectMark4=mark4;
        }
        public static Semester operator +(Semester sem1,Semester sem2)
        {
            Semester result =new Semester(0,0,0,0);
            result._total=sem1._total+sem2._total;
            result._percent=result._total/800*100;
            return result;
        }
        public void CalculationMark()
        {
            _total= SubjectMark1+SubjectMark2+SubjectMark3+SubjectMark4;
        }
        public void CalculatePercent()
        {
            _percent= _total/400*100;
        }
    }
}