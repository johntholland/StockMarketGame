using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public class Stock
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Dividend { get; set; }
        public int BottomPrice { get; set; }
        public int TopPrice { get; set; }

        public static Stock Alcoa
        {
            get
            {
                return new Stock()
                {
                    Name = "Alcoa",
                    Dividend = 4,
                    BottomPrice = 30,
                    TopPrice = 300
                };
            }
        }

        public static Stock Woolsworth
        {
            get
            {
                return new Stock()
                {
                    Name = "Woolsworth",
                    Dividend = 4,
                    BottomPrice = 30,
                    TopPrice = 300
                };
            }
        }

        public static Stock WesternPublishing
        {
            get
            {
                return new Stock()
                {
                    Name = "WesternPublishing",
                    Dividend = 3,
                    BottomPrice = 15,
                    TopPrice = 150
                };
            }
        }
    }
}
