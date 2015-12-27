using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public class Market
    {
        public int Index { get; set; }

        public uint Price(Stock stock)
        {
            return stock.Prices[this.Index];
        }

        public Market()
        {
            this.Index = 25;//0 index
        }

        public void Move(int marketMovement)
        {
            if (this.Index + marketMovement > 50)
            {
                marketMovement = (50 - (this.Index + marketMovement));
            }

            if (this.Index + marketMovement < 0)
            {
                marketMovement = (this.Index - marketMovement);
            }

            this.Index += marketMovement;
        }

        public override string ToString()
        {
            return this.Index.ToString();
        }
    }
}
