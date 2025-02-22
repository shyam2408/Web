using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineDTHRecharge
{
    public class RechargeHistoryDetails
    {
        /// <summary>
        /// static field for this class
        /// </summary>
        private static int s_rechargeID = 100;
        /// <summary>
        /// used to generate recharge for the customer
        /// </summary>
        /// <value>returns the string </value>
        public string RechargeID { get; set; }
        /// <summary>
        /// used to pass the string through parameters
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// used to pass the string through parameters
        /// </summary>
        /// <value></value>
        public string PackID { get; set; }
        /// <summary>
        /// used to pass the string through parameters
        /// </summary>
        /// <value></value>
        public DateTime RechargeDate { get; set; }
        /// <summary>
        /// used to set the startdate for recharge
        /// </summary>
        /// <value>returns the datetime</value>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// used to set the startdate for recharge
        /// </summary>
        /// <value>returns the datetime</value>
        public DateTime ValidTill { get; set; }
        /// <summary>
        /// used to set the startdate for recharge
        /// </summary>
        /// <value>returns the datetime</value>
        public double RechargeAmount { get; set; }
        /// <summary>
        /// used to set the integer  for recharge
        /// </summary>
        /// <value>returns the integer</value>
        public int NumberOfChannels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID">used to pass the user id to the constructer</param>
        /// <param name="packID">used to pass the PackID id to the constructer</param>
        /// <param name="rechargeDate">used to pass date user id to the constructer</param>
        /// <param name="startDate">used to pass the date id to the constructer</param>
        /// <param name="validTill">used to pass the date to the constructer</param>
        /// <param name="rechargeAmount">used to pass the recaherge amount to the constructer</param>
        /// <param name="numberOfChannels">used to pass the numberof channels to the constructer</param>
        public RechargeHistoryDetails(string userID, string packID, DateTime rechargeDate, DateTime startDate, DateTime validTill, double rechargeAmount, int numberOfChannels)
        {
            RechargeID = $"RP{++s_rechargeID}";
            UserID = userID;
            PackID = packID;
            RechargeDate = rechargeDate;
            StartDate = startDate;
            ValidTill = validTill;
            RechargeAmount = rechargeAmount;
            NumberOfChannels = numberOfChannels;

        }
    }
}