using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Screening
    {
        public Movie Movie { get; set; }
        public DateTime StartTime { get; set; }
        public Ticket[] Ticket { get; set; }
        private int ticketCount = 0;
        public Screening(Movie movie, DateTime startTime, int ticketCapacity)
        {
            Movie = movie;
            StartTime = startTime;
            Ticket = new Ticket[ticketCapacity];
        }
        public bool AddTicket(Ticket ticket)
        {
            if (ticketCount < Ticket.Length)
            {
                Ticket[ticketCount] = ticket;
                ticketCount++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Ticket FindTicketById(int ticketId)
        {
            for (int i = 0; i < ticketCount; i++)
            {
                if (Ticket[i].Id == ticketId)
                {
                    return Ticket[i];
                }
            }
            return null;
        }
    }
}
