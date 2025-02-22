using System;
using TheatreTicketBookingApplication;
namespace TheatreTicketBookingAppliction;

class Program
{
    public static void Main(string[]args)
    {
        Offline ticket1=new Offline();
        ticket1.UpdateTicketInfo("lakshmi","offline",989,88);
        ticket1.Display();
        Online ticket2=new Online();
        ticket2.UpdateTicketInfo("vijaya","online",109,100);
        ticket2.Display();
    }
}
