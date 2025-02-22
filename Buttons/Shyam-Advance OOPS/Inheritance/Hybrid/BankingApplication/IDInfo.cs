using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobApplicationPortal;

namespace BankingApplication
{
    public class IDInfo : PersonalInfo
    {
        public string VoterID { get; set; }
        public string AadharID { get; set; }
        public string PANNumber { get; set; }
        public IDInfo() { }
        public IDInfo(string name, string phone, string dob, string gender, string voterID, string aadharID, string pANNumber) : base(name, phone, dob, gender)
        {
            VoterID = voterID;
            AadharID = aadharID;
            PANNumber = pANNumber;
        }
        public string DisplayInfo()
        {
            return $"{DiplayPersonalInfo()}\nVoterID :{VoterID}\nAadharID :{AadharID}\nPan number :{PANNumber}";
        }
    }
}