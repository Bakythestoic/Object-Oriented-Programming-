using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Member
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string MembershipType { get; set; }
        public Member(string name, string email, string membershipType)
        {
            Name = name;
            Email = email;
            MembershipType = membershipType;
        }
        public double GetDiscountedPrice(double price)
        {
            // Example discount logic - replace with actual discount calculation
            if (MembershipType == "Silver")
            {
                return price - (price * 0.05); // Apply 5% discount
            }
         

            if (MembershipType == "Gold")   
            {
                return price - (price * 0.1); // Apply 10% discount
            }
           
            if (MembershipType == "Platinum")
            {
                return price - (price * 0.15); // Apply 15% discount
            }
            return price;
        }
    }
}
