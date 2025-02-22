using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Number1
{
    public interface IFamilyInfo
    {
        //FatherName, , ,   
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSiblings { get; set; }
    }
}