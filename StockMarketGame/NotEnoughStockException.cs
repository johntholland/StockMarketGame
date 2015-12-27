using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public class NotEnoughStockException:Exception
    {
        public NotEnoughStockException():base("Not enough Stock"){}
    }
}
