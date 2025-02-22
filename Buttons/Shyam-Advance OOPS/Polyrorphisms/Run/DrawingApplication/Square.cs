using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrawingApplication
{
    public class Square:Shape
    {
        public override string DrawShape()
        {
            return DrawSquare();
        }
        public string DrawSquare()
        {
            return "the shape is square";
        }
    }
}