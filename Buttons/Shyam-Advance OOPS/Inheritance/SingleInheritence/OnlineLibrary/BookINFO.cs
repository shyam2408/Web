using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class BookINFO:ClassDepartmentDetails
    {
        /*BookID, BookName, AuthorName, Price*/
        private static int s_bookID=0;
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public BookINFO(int departmentID,string departmentName,string degree,string bookName,string authorName,double price):base(departmentID,departmentName,degree)
        {
            BookID=++s_bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public string DisplayBookDetails()
        {
            return $"BookID :{BookID}\n{DisplayClassDetails()}\nBookName :{BookName}\nAuthorName :{AuthorName}\nPrice :{Price}";
        }
    }
}