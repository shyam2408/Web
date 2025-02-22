using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class BookingDetails
    {
        /*a. BookingID (Auto Increment – BID3000)CustomerID TotalPrice DateOfBooking 
        BookingStatus {Enum – }*/
        private static int s_idCounter=3000;
        public string BookingID { get; set; }
        public string CustomerID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus Booking  { get; set; }
        public BookingDetails(string customerID,double totalPrice,DateTime dateOFBooking,BookingStatus booking)
        {
            BookingID=$"BID{++s_idCounter}";
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfBooking=dateOFBooking;
            Booking=booking;
        }
    }
}