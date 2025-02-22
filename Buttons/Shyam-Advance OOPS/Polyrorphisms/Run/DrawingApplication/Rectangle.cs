using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrawingApplication
{
    public class Rectangles:Shape
    {
        public override string DrawShape()
        {
            return DrawRectangle();
        }
        public string DrawRectangle()
        {
            return "The shape is Rectangle";
        }
        
    }
}