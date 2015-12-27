using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame.Tests
{
    public class TestPlayer1 : Player
    {
        public TestPlayer1() : base("Test1")
        {
            this.Cash = 500;
            this.AddStock(Stock.Woolsworth, 5);
            this.AddStock(Stock.Alcoa, 5);
        }
    }

    public class TestPlayer2 : Player
    {
        public TestPlayer2() : base("Test2")
        {
            this.Cash = 1000;
            this.AddStock(Stock.WesternPublishing, 5);
            this.AddStock(Stock.InternationalShoe, 5);
        }
    }
}
