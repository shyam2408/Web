using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public interface IBankInfo
    {
        //BankName, IFSC, Branch
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }
    }
}