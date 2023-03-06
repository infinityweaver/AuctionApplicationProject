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
        public double ActualBalance { get; set; }
        public double ProjectedBalance { get; set; }

        public Bidder(string name, string username, string password, double initialDeposit) : base(name, username, password)
        {
            this.BidderNumber = BIDDER_COUNTER++;
            this.ActualBalance = initialDeposit;
            this.ProjectedBalance = this.ActualBalance;
        }

        private Bidder(Bidder bidder) : base (bidder.Name, bidder.Username, bidder.Password)
        {
            this.BidderNumber = bidder.BidderNumber;
            this.ActualBalance = this.ProjectedBalance = 0;
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
