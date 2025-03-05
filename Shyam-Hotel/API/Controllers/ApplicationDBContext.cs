using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelAPI.Models;
namespace HotelAPI.Controllers
{
    public class ApplicationDBContext : ControllerBase
    {
        public static List<CustomerRegistration> customers = new List<CustomerRegistration>()
        {
            new CustomerRegistration{ CustomerID = "CID1001", Name = "Saravanan", Aadhar = "12323",  Gender = "Male", MailID = "saravanan@gmail.com", MobileNumber = "8347484894", Password = "Saravana@123", WalletBalance = 1000, ProfilePhoto = "./Images/Screenshot 2025-02-28 103356.png"}
        };


        public static List<RoomDetails> roomItems = new List<RoomDetails>(){
            new RoomDetails{RoomID="RID2001",RoomType="Standard",NumberOfBeds=2,PricePerDay=500,RoomImage="./Images/1.png"},
            new RoomDetails{RoomID="RID2002",RoomType="Standard",NumberOfBeds=2,PricePerDay=500,RoomImage="./Images/2.png"},
            new RoomDetails{RoomID="RID2003",RoomType="Standard",NumberOfBeds=2,PricePerDay=100,RoomImage="./Images/3.png"},
            new RoomDetails{RoomID="RID2004",RoomType="Standard",NumberOfBeds=2,PricePerDay=200,RoomImage="./Images/4.png"},
            new RoomDetails{RoomID="RID2005",RoomType="Standard",NumberOfBeds=4,PricePerDay=800,RoomImage="./Images/5.png"},
            new RoomDetails{RoomID="RID2006",RoomType="Delux",NumberOfBeds=5,PricePerDay=1200,RoomImage="./Images/6.png"},
            new RoomDetails{RoomID="RID2007",RoomType="Delux",NumberOfBeds=2,PricePerDay=500,RoomImage="./Images/7.png"},
            new RoomDetails{RoomID="RID2008",RoomType="Delux",NumberOfBeds=2,PricePerDay=1500,RoomImage="./Images/1.png"},
            new RoomDetails{RoomID="RID2009",RoomType="Suit",NumberOfBeds=2,PricePerDay=500,RoomImage="./Images/2.png"},
            new RoomDetails{RoomID="RID2010",RoomType="Suit",NumberOfBeds=5,PricePerDay=500,RoomImage="./Images/3.png"},
            new RoomDetails{RoomID="RID2011",RoomType="Suit",NumberOfBeds=3,PricePerDay=400,RoomImage="./Images/4.png"},
            new RoomDetails{RoomID="RID2012",RoomType="Suit",NumberOfBeds=2,PricePerDay=900,RoomImage="./Images/5.png"},
            new RoomDetails{RoomID="RID2013",RoomType="Suit",NumberOfBeds=4,PricePerDay=350,RoomImage="./Images/6.png"}
        };
        public static List<RoomSelection> roomSelections = new List<RoomSelection>();
        public static List<Wishlist> wishlists = new List<Wishlist>();
        public static List<BookingDetails> bookings = new List<BookingDetails>();
    }
}