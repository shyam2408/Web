using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPortal
{
    public interface ImarkDetails
    {
        public int[] Sem1 { get; set; }
        public int[] Sem2 { get; set; }
        public int[] Sem3 { get; set; }
        public int[] Sem4 { get; set; }
    }
}