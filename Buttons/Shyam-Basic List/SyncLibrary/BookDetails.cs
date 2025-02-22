using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncLibrary
{
    public class BookDetails
    {
        private static int s_bookID=1000;
        private string _bookID;
        public string BookID { get{return _bookID;} set{_bookID=value; s_bookID=Convert.ToInt32(value[3..]);} }
        public string BookName { get; set; }
        public string  AuthorName { get; set; }
        public AvailabilityStatus Status { get; set; }
        public BookDetails(){}

        public BookDetails(string bookName,string authorName,AvailabilityStatus status)
        {
            BookID=$"BID{++s_bookID}";
            BookName=bookName;
            AuthorName=authorName;
            Status=status;
        }
        
        
    }
}