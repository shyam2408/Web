using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncLibrary
{
    public class BorrowDetails
    {
        /*
        •	BorrowID (Auto Increment – LB2000)
•	BookID 
•	UserID
•	BorrowedDate – (Current Date)
•	BookingStatus – (Enum - Default, Borrowed, Returned)
•	PaidFineAmount

        */
        private static int s_borrowID=2000;
        private string _borrowID;
        public string BorrowID { get{return _borrowID;} set{_borrowID=value; s_borrowID=Convert.ToInt32(value.Remove(0,2));} }
        public string BookID { get; set; }
        public string UserID { get; set; }
        public DateTime BorrowedDate { get; set; }
        public BookingStatus BookStatus { get; set; }
        public double PaidFineAmount { get; set; }
        public BorrowDetails(){}

        public BorrowDetails(string bookID,string userID,DateTime borrowedDate,BookingStatus bookStatus,double paidFineAmount)
        {
            _borrowID=$"LB{++s_borrowID}";
            BookID=bookID;
            UserID=userID;
            BorrowedDate=borrowedDate;
            BookStatus=bookStatus;
            PaidFineAmount=paidFineAmount;
        }
    }
}