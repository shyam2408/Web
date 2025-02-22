using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrawingApplication
{
    public class Line:Shape
    {
        public override string DrawShape()
        {
            return DrawLine();
        }
        public string DrawLine()
        {
            return "The Shape is Line";
        }
    }
}