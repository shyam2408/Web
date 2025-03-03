using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace GroceryWebAPI.Models
{
    public class BookingDetails
    {
        public string BookingID { get; set; }
        public string CustomerID { get; set; }
        public double TotalPrice { get; set; }
        public string DateOfBooking { get; set; }
        public string BookingStatus { get; set; }

    }
}