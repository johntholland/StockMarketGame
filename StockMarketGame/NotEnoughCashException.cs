using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public class NotEnoughCashException:Exception
    {
        public NotEnoughCashException():base("Not Enough Cash"){}
    }
}
