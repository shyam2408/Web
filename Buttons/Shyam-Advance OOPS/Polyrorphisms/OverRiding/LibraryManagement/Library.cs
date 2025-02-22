using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public abstract class Library
    {
        /*Abstract class Library
        Field : serialNumber 
        Property : SerialNumber - LIB1000
        Abstract properties: AuthorName, BookName, PublisherName, Year
        Abstract methods: UpdatebookInfo*/
        private static int s_serialNumber=1000;
        public abstract string SerialNumber { get; set; }
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract int Year { get; set; }
        public Library(string authorName,string bookName,string publisherName,int year)
        {
            SerialNumber= $"LIB{++s_serialNumber}";
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=Year;
        }
        public abstract string UpdatebookInfo();
        
    }
}