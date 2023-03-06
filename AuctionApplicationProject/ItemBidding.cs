using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApplicationProject
{
    public class ItemBidding
    {
        public Item item { get; private set; }
        private Dictionary<Bidder, double> bids;
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public DateTime DateTimeCreated { get; private set; }
        public Seller Seller { get; private set; }
        public double MinimumBid { get; private set; }
        public bool IsAwarded { get; private set; }
        public bool IsBiddingPhase
        {
            get
            {
                return this.StartDateTime <= DateTime.Now &&
                        DateTime.Now <= this.EndDateTime;
            }
        }

        public Bidder HighestBidder
        {
            get
            {
                if (this.bids.Count == 0)
                    return null;
                else
                    return this.bids.MaxBy(x => x.Value).Key;
            }
        }

        public double HighestBid
        {
            get
            {
                if (this.HighestBidder == null)
                    return -1;
                else
                    return this.bids[this.HighestBidder];
            }
        }

        public ItemBidding(Item item, DateTime startDateTime, DateTime endDateTime, Seller seller, double minimumBid)
        {
            this.item = item;
            this.bids = new Dictionary<Bidder, double>();
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.DateTimeCreated = DateTime.Now;
            this.Seller = seller;
            this.MinimumBid = minimumBid;
        }

        public bool Bid(Bidder bidder, double amount)
        {
            bool success = false;

            if(this.IsBiddingPhase && this.bids.ContainsKey(bidder) && this.bids[bidder] < amount)
            {
                this.bids[bidder] = amount;
                success = true;
            }

            return success;
        }
    }
}
