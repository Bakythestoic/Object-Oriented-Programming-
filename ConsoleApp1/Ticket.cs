using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ticket
    {
        public int Id {  get; set; }
        public double Price { get; private set; }
        public Ticket(int id, double price)
        {
            Id = id;
            Price = price;
        }
        public void IncreasePrice(double percentage)
        {
            Price += Price * percentage / 100;
        }
        public void DecreasePrice(double percentage)
        {
            Price -= Price * percentage / 100;
        }

    }
}
