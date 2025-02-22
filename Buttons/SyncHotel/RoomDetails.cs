using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHotel
{
    public class RoomDetails
    {
        /*
            Properties: 
            •	RoomID (Auto Increment – RID2000)
            •	RoomType (Enum – Standard, Delux, Suit)
            •	NumberOfBeds
            •	PricePerDay
        */
        private static int s_roomID =2000;
        private string _roomID;

        public string RoomID { get{ return _roomID;} set{_roomID = value ;  s_roomID = int.Parse(value.Remove(0,3)) ;} }
        public RoomType RoomType { get; set; }
        public int NumberOfBeds { get; set; }
        public double PricePerDay { get; set; }


        //Constructors
        //public RoomDetails(){}
        public RoomDetails(RoomType roomType, int numberOfBeds, double pricePerDay)
        {
            _roomID = $"RID{++s_roomID}";
            RoomType = roomType ;
            NumberOfBeds = numberOfBeds;
            PricePerDay = pricePerDay;
        }
    }
}