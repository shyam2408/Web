using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineDTHRecharge
{
    public class PackDetails
    {
        public string PackID { get; set; }
        /// <summary>
        /// pack name is a sstring used to store parameter
        /// </summary>
        /// <value>returns the string to the corresponding parameter</value>
        public string PackName { get; set; }
        /// <summary>
        /// price is used to pass parice torough parameter
        /// </summary>
        /// <value>returns the double value </value>
        public double Price { get; set; }
        /// <summary>
        /// price is used to pass validity torough parameter
        /// </summary>
        /// <value>returns the int value </value>
        public int Validity { get; set; }
        /// <summary>
        /// price is used to pass number of channels torough parameter
        /// </summary>
        /// <value>returns the int value </value>
        public int NunmberOfChannels { get; set; }
        /// <summary>
        /// constructor for this class
        /// </summary>
        /// <param name="packID"></param>
        /// <param name="packName"></param>
        /// <param name="price"></param>
        /// <param name="validity"></param>
        /// <param name="numberOfChannels"></param>
        public PackDetails(string packID, string packName, double price, int validity, int numberOfChannels)
        {
            PackID = packID;
            PackName = packName;
            Price = price;
            Validity = validity;
            NunmberOfChannels = numberOfChannels;
        }
    }
}