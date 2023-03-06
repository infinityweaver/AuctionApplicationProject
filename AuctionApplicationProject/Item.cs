using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApplicationProject
{
    public class Item
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double MinimumBid { get; private set; }

        public Item(string name, string description, double minimumBid)
        {
            this.Name = name;
            this.Description = description;
            this.MinimumBid = minimumBid;
        }
    }
}
