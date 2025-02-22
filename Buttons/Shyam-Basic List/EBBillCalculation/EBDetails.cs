using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBillCalculation
{
    public class EBDetails
    {
        private static int s_meterID = 4000;//icrementing purposes
        public String MeterID { get; set; }//to store student id
        public string UserName { get; set; }//auto implemented properties----accessors --read only
        public string PhoneNumber { get; set; }
        public string MailID { get; set; }
        public double UnitsUsed { get; set; }


        public EBDetails(string uname, string phoneNumber, string mailID, double unitsUsed)
        {
            //assign parameter values to properties
            MeterID = $"EB{++s_meterID}";
            UserName = uname;
            PhoneNumber = phoneNumber;
            MailID = mailID;
            UnitsUsed = unitsUsed;
        }


        public double CalculateBill()
        {
            if (UnitsUsed < 100 && UnitsUsed > 0)
            {
                return 0;
            }
            else if (UnitsUsed > 100 && UnitsUsed < 200)
            {
                return (UnitsUsed-100)*2;
            }
            else if (UnitsUsed > 200 && UnitsUsed < 400)
            {
                return 200 +(UnitsUsed-200)*5;
            }
            else
            {
                return 1200 + (UnitsUsed-400)*8;
            }
        }
    }
}