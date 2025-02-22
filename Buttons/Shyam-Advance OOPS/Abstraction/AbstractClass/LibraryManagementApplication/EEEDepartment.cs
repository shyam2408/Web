using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication
{
    public class EEEDepartment:Library
    {
        private static int s_serialNumber=1000;
        public override string SerialNumber { get; set; }
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override int Year { get; set; }
        public EEEDepartment(string authorName,string bookName,string publisherName,int year)
        {
            SerialNumber=$"LIB{++s_serialNumber}";
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
        }


        public override string SetBookInfo(string authorName,string bookName,string publisherName,int year)
        {
            return $"Serial Number :{SerialNumber}\nAuthor Name:{authorName}\nBookName :{bookName}\nPublisher Name :{publisherName}\nYear :{year}";
        }

        public string UpdateBookInfo(string authorName,string bookName,string publisherName,int year)
        {
            return $"Serial Number :{SerialNumber}\nAuthor Name:{authorName}\nBookName :{bookName}\nPublisher Name :{publisherName}\nYear :{year}";
        }
    }
}