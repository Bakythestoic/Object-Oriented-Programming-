using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Staff
    {
        public string Name{ get; set; }
        public string Email{ get; set; }
        public Staff(string name, string email)
        {
            Name = name;
            Email = email;
        }   
        public void DisplayInfo()
        {
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("Email:"+Email);
        }

    }
}
