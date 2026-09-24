using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Usher:Staff
    {
        public int AssignedScreen { get; set; }

        public Usher(string name, string email, int assignedScreen) : base(name, email)
        {
            AssignedScreen = assignedScreen;
        }
        public void DisplayUsherInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Assigned Screen: " + AssignedScreen);
        }
    }
}
