using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreTicketBookingApplication
{
    public abstract class Ticket
    {
        public int s_ticket=100;
        public int TicketID { get; set; }
        public string TeatreName { get; set; }
        public int TicketPrice { get; set; }
        public abstract string Tickettype { get; set; }
        public abstract int  SeatNo { get; set; }
        public Ticket()
        {
            TicketID=++s_ticket;
        }

        public abstract void UpdateTicketInfo(string theatrename,string tickettype,int ticketPrice,int seatNo);
    }
}