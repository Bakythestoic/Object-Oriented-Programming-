using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie  = new Movie ("Entagalactic", 120);
            Ticket ticket = new Ticket(1, 10.0);
            Console.WriteLine(movie.Title);
            Console.WriteLine(movie.Duration);
            Console.WriteLine(ticket.Id);
            ticket.IncreasePrice(10);
            Console.WriteLine(ticket.Price);
            ticket.DecreasePrice(5);
            Console.WriteLine(ticket.Price);
            Usher usher = new Usher("John", "john@example.com", 25);
            Console.WriteLine("Usher Info:");
            usher.DisplayUsherInfo();
            Manager manager = new Manager("Jane", "jane@example.com", 123);
            Console.WriteLine("Manager Info:");
            manager.DisplayManagerInfo();
            
            Screening screening = new Screening(movie, new DateTime(2023, 10, 15, 18, 0, 0), 1);
            Ticket ticket1 = new Ticket(101, 10);
            Ticket ticket2 = new Ticket(102, 10);
            Ticket ticket3 = new Ticket(103, 10);
            Console.WriteLine(screening.AddTicket(ticket1)); 
            Console.WriteLine(screening.AddTicket(ticket2));
            Console.WriteLine(screening.AddTicket(ticket3));
            Ticket foundTicket = screening.FindTicketById(102);
            if (foundTicket != null)
            {
                Console.WriteLine("Ticket found:" + foundTicket.Id + ", Price:" + foundTicket.Price);
            }
            else
            {
                Console.WriteLine("Ticket not found.");
            }
            Member Silvermember = new Member("Alice", "alice@example.com", "Silver");
            Member Goldmember = new Member("Bob", "bob@example.com", "Gold");
            Member Platinummember = new Member("Charlie", "charlie@example.com", "Platinum");
            double ticketPrice = 10.0;
            Console.WriteLine("Silver Member Discounted Price: " + Silvermember.GetDiscountedPrice(ticketPrice));
            Console.WriteLine("Gold Member Discounted Price: " + Goldmember.GetDiscountedPrice(ticketPrice));
            Console.WriteLine("Platinum Member Discounted Price: " + Platinummember.GetDiscountedPrice(ticketPrice));
        }
    }
}
