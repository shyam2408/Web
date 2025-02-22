using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class BookInfo : RackInfo
    {
        private static int s_bookID = 0;
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        public BookInfo(string departmentName, string degree, int rackID, int columnNumber, string bookName, string authorName, double price) : base(departmentName, degree, rackID, columnNumber)
        {
            BookID = ++s_bookID;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }
        public string DisplayBookInfo()
        {
            return $"{DisplayRackDetails()}\nBookID :{BookID}\nBookName :{BookName}\nAuthor Name:{AuthorName}\nPrice :{Price}";
        }
    }
}