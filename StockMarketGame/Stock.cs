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
        public uint Price { get; set; }
        public uint Dividend { get; set; }
        public uint BottomPrice { get; set; }
        public uint TopPrice { get; set; }

        public static Stock Woolsworth
        {
            get
            {
                return new Stock()
                {
                    Name = "Woolsworth",
                    Dividend = 4,
                    BottomPrice = 30,
                    TopPrice = 230
                };
            }
        }

        public static Stock Alcoa
        {
            get
            {
                return new Stock()
                {
                    Name = "Alcoa",
                    Dividend = 4,
                    BottomPrice = 30,
                    TopPrice = 230
                };
            }
        }

        public static Stock WesternPublishing
        {
            get
            {
                return new Stock()
                {
                    Name = "Western Publishing",
                    Dividend = 3,
                    BottomPrice = 10,
                    TopPrice = 110
                };
            }
        }

        public static Stock AmericanMotors
        {
            get
            {
                return new Stock()
                {
                    Name = "American Motors",
                    Dividend = 3,
                    BottomPrice = 10,
                    TopPrice = 110
                };
            }
        }

        public static Stock Maytag
        {
            get
            {
                return new Stock()
                {
                    Name = "Maytag",
                    Dividend = 2,
                    BottomPrice = 15,
                    TopPrice = 75
                };
            }
        }

        public static Stock JICase
        {
            get
            {
                return new Stock()
                {
                    Name = "J.I. Case",
                    Dividend = 2,
                    BottomPrice = 15,
                    TopPrice = 75
                };
            }
        }

        public static Stock InternationalShoe
        {
            get
            {
                return new Stock()
                {
                    Name = "International Shoe",
                    Dividend = 1,
                    BottomPrice = 18,
                    TopPrice = 42
                };
            }
        }

        public static Stock GeneralMills
        {
            get
            {
                return new Stock()
                {
                    Name = "General Mills",
                    Dividend = 1,
                    BottomPrice = 18,
                    TopPrice = 42
                };
            }
        }

    }
}
