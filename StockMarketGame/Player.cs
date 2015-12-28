using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public class Player
    {
        public string Name { get; set; }
        public Dictionary<string, uint> ShareQuantities { get; set; }
        public uint Cash { get; set; }
        public string Color { get; set; }

        public ISpace CurrentSpace { get; set; }
        public Job CurrentJob { get; set; }

        public Player(string name)
        {
            this.Name = name;
            this.Cash = Cash;
            this.ShareQuantities = new Dictionary<string, uint>();
            this.AddStock(Stock.Alcoa, 0);
            this.AddStock(Stock.AmericanMotors, 0);
            this.AddStock(Stock.GeneralMills, 0);
            this.AddStock(Stock.InternationalShoe, 0);
            this.AddStock(Stock.JICase, 0);
            this.AddStock(Stock.Maytag, 0);
            this.AddStock(Stock.WesternPublishing, 0);
            this.AddStock(Stock.Woolsworth, 0);
        }

        public void AddStock(Stock stock, uint quantity)
        {
            if (this.ShareQuantities.Keys.Contains(stock.Name))
            {
                this.ShareQuantities[stock.Name] += quantity;
            }
            else
            {
                this.ShareQuantities.Add(stock.Name, quantity);
            }
        }

        public void Sell (Stock stock, uint quantity, uint stockPrice)
        {
            var shares = this.ShareQuantities[stock.Name];

            if (shares >= quantity)
            {
                this.Cash += quantity * stockPrice;
                this.ShareQuantities[stock.Name] = shares - quantity;
            }
            else
            {
                throw new NotEnoughStockException();
            }
        }

        public void Buy(Stock stock, uint quantity, uint stockPrice)
        {
            var shares = this.ShareQuantities[stock.Name];

            if (this.Cash >= quantity * stockPrice)
            {
                this.Cash -= quantity * stockPrice;
                this.ShareQuantities[stock.Name] = shares + quantity;
            }
            else
            {
                throw new NotEnoughCashException();
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
