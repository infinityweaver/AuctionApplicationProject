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

        public ItemBidding(Item item, DateTime startDateTime, DateTime endDateTime)
        {
            this.item = item;
            this.bids = new Dictionary<Bidder, double>();
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.DateTimeCreated = DateTime.Now;
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
