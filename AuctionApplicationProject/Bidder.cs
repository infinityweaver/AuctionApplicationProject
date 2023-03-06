using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApplicationProject
{
    public class Bidder : ICloneable
    {
        private static int BIDDER_COUNTER = 1;

        public int BidderNumber { get; private set; }
        public string Name { get; private set; }

        public Bidder(string name)
        {
            this.BidderNumber = BIDDER_COUNTER++;
            this.Name = name;
        }

        private Bidder(Bidder bidder)
        {
            this.BidderNumber = bidder.BidderNumber;
            this.Name = bidder.Name;
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
