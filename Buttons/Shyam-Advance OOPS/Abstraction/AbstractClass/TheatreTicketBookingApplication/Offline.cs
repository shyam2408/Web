using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreTicketBookingApplication
{
    public class Offline:Ticket
    {
        public override string Tickettype { get; set; }
        public override int  SeatNo { get; set; }

        public override void UpdateTicketInfo(string theatrename,string tickettype,int ticketPrice,int seatNo)
        {
            TeatreName=theatrename;
            Tickettype=tickettype;
            TicketPrice=ticketPrice;
            SeatNo=seatNo;
        }
        public void Display()
        {
            System.Console.WriteLine($"TicketID :{TicketID}\nTheatre name :{TeatreName}\nTiocket Price :{TicketPrice}\nSeatNo:{SeatNo}");
        }
    }
}