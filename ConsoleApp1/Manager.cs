using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Manager : Staff
    {
        public int ExtensionNumber { get; set; }
        public Manager(string name, string email, int extensionNumber) : base(name, email)
        {
            ExtensionNumber = extensionNumber;
        }
        public void DisplayManagerInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Extension Number: " + ExtensionNumber);
        }
    }
}
