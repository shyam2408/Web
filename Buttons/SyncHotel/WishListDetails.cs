using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHotel
{
    public class WishListDetails
    {
        /*
        Properties : 
            WishListID (WSID --> 3000),	UserID,	RoomID,	PriceOfRoom, FromDate,	ToDate.
        */

        private static int s_wishListID = 3000;
        private string _wishListID;

        public string WishListID { get{ return _wishListID ;} set{_wishListID = value ; s_wishListID = int.Parse(value.Remove(0,4)) ; }  }
        public string UserID { get; set; }
        public string RoomID { get; set; }
        public double PriceOfRoom { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    
        //Constructors
        public WishListDetails(){}
        public WishListDetails(string userID, string roomID,double priceOfRoom, DateTime fromDate, DateTime toDate)
        {
            _wishListID = $"WSID{++s_wishListID}";
            UserID = userID;
            RoomID = roomID;
            PriceOfRoom = priceOfRoom;
            FromDate = fromDate;
            ToDate = toDate;
        }
    
    }
}