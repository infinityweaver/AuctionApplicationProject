using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApplicationProject
{
    public class Seller : User
    {
        public double ActualEarnings { get; set; }

        public Seller(string name, string username, string password) : base(name, username, password)
        {
            this.ActualEarnings = 0;
        }
    }
}
