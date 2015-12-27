using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame.Tests
{
    public class TestMarket1:Market
    {
        public TestMarket1():base()
        {
            this.Index = 15;
        }
    }

    public class TestMarket2 : Market
    {
        public TestMarket2() : base()
        {
            this.Index = 0;
        }
    }
}
