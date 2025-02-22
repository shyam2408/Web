using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHotel
{
    public class BookingDetails
    {
        /*
        Properties
            •	BookingID (Auto increment-BID4000)
            •	UserID
            •	TotalPrice 
            •	DateOfBooking
            •	BookingStatus (Default, Initiated, Booked, Cancelled)

        */

        private static int s_bookingID = 4000;
        private string _bookingID;

        public string BookingID { get{ return _bookingID ;} set{_bookingID = value ; s_bookingID = int.Parse(value.Remove(0,3)) ; } }
        public string UserID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }

        //Constructors
        public BookingDetails(){}
        public BookingDetails(string userID, double totalPrice, DateTime dateOfBooking, BookingStatus bookingStatus)
        {
            _bookingID = $"BID{++s_bookingID}";
            UserID = userID ;
            TotalPrice = totalPrice;
            DateOfBooking = dateOfBooking;
            BookingStatus = bookingStatus;
        }

    }
}