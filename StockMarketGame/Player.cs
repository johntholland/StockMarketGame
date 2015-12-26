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
        public Dictionary<Stock, int> ShareQuantities { get; set; }
        public uint Cash { get; set; }

        public ISpace CurrentSpace { get; set; }
        public Job CurrentJob { get; set; }

        public Player(string name)
        {
            this.Name = name;
            this.Cash = Cash;
            this.ShareQuantities = new Dictionary<Stock, int>();
        }

        public void Sell (Stock stock, uint quantity, int stockPrice)
        {
            
        }

        public void Buy(Stock stock, uint quantity, int stockPrice)
        {

        }
    }
}
