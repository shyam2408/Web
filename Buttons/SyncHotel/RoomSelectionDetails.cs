using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHotel
{
    public class RoomSelectionDetails
    {
        /*
        Properties:
        •	SelectionID (Auto Increment – SID5000)
        •	WishListID
        •	BookingID
        •	RoomID
        •	StayingDateFrom
        •	StayingDateTo
        •	Price
        •	NumberOfDays
        •	BookingStatus (Default, Initiated, Booked, Cancelled)
        */

        private static int s_selectionID = 5000;
        private string _selectionID;
        public string SelectionID { get{ return _selectionID ;} set{_selectionID = value ; s_selectionID = int.Parse(value.Remove(0,3)) ; } }
        public string WishListID { get; set; }
        public string BookingID { get; set; }
        public string RoomID { get; set; }
        public DateTime StayingDateFrom { get; set; }
        public DateTime StayingDateTo { get; set; }
        public double Price { get; set; }
        public double NumberOfDays { get; set; }
        public RoomBookingStatus BookingStatus { get; set; }


        //COnstructors
        public RoomSelectionDetails(){}
        public RoomSelectionDetails(string wishListID, string bookingID, string roomID, DateTime stayingDateFrom, DateTime stayingDateTo, double price, double numberOfDays, RoomBookingStatus bookingStatus )
        {
            _selectionID = $"SID{++s_selectionID}";
            WishListID = wishListID;
            BookingID = bookingID;
            RoomID = roomID;
            StayingDateFrom = stayingDateFrom;
            StayingDateTo = stayingDateTo;
            Price = price;
            NumberOfDays  =  numberOfDays;
            BookingStatus = bookingStatus;
        }
    }
}