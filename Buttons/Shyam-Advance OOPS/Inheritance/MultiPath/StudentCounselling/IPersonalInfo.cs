using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCounselling
{
    public interface IPersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string AadharNumber { get; set; }
    }
}