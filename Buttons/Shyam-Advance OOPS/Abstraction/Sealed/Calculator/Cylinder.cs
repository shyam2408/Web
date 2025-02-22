using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class Cylinder:Circle
    {
        public double Height { get; set; }

        public Cylinder(double h,double r):base(r)
        {
            Height=h;
            Radius=r;
        }
        public override void Area()
        {
            
        }
        public override void Volume()
        {

        }
    }
}