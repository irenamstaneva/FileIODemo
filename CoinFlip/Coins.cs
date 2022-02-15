using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    internal class Coins
    {
        public bool isHeads { get; set; }

        public Coins(bool isHeads)
        {
            this.isHeads = isHeads;
        }

        public void FlipCoin(Random r) 
        { 
            
            if (r.Next(10) > 5)
            {
                isHeads = true;
            }
            else
            {
                isHeads = false;
            }
        }
    }
}
