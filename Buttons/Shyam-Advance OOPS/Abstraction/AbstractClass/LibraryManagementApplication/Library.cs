using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication
{
    public abstract class Library
    {
       
        //SerialNumber -LIB1000 (Auto increment)Abstract properties: AuthorName, BookName, PublisherName, Year
        //Abstract methods: SetBookInfo
        public abstract string SerialNumber { get; set; }
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract int Year { get; set; }

        public abstract string SetBookInfo(string authorName,string bookName,string publisherName,int year);


    }
}