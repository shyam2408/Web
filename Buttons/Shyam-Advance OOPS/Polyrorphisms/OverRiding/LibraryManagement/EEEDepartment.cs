using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class EEEDepartment:Library
    {
        private static int s_serialNumber=1000;
        public  string SerialNumberID { get; set; }
        public override string SerialNumber { get; set; }
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override int Year { get; set; }
        public EEEDepartment(string authorName,string bookName,string publisherName,int year):base(authorName,bookName,publisherName,year)
        {
            SerialNumber= $"LIB{++s_serialNumber}";
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
        }
        public override string UpdatebookInfo()
        {
            return $"AuthorName :{AuthorName}\nSerialNumber :{SerialNumber}\nBook Name :{BookName}\npublisher Name :{PublisherName}\nYear :{Year}";
        }
    }
}