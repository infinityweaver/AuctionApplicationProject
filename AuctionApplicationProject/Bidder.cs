using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApplicationProject
{
    public class Bidder : User, ICloneable
    {
        private static int BIDDER_COUNTER = 1;

        public int BidderNumber { get; private set; }

        public Bidder(string name, string username, string password) : base(name, username, password)
        {
            this.BidderNumber = BIDDER_COUNTER++;
        }

        private Bidder(Bidder bidder) : base (bidder.Name, bidder.Username, bidder.Password)
        {
            this.BidderNumber = bidder.BidderNumber;
        }

        public object Clone()
        {
            return new Bidder(this);
        }

        public override bool Equals(object? obj)
        {
            return obj != null &&
                obj is Bidder &&
                ((Bidder)obj).BidderNumber == this.BidderNumber;
        }
    }
}
