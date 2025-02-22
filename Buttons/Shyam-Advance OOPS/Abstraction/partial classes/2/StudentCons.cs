using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Two
{
    public partial class Student
    {
        private static int s_id=5000;
        public Student()
        {
            StudentID=++s_id;
        }
        
    }
}