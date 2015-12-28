using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public class Woolsworth: Stock
    {
        public Woolsworth()
        {
            this.Name = "Woolsworth";
            this.Dividend = 4;
            this.Prices = new uint[51] { 30, 34, 38, 42, 46, 50, 54, 58, 62, 66, 70, 74, 78, 82, 86, 90, 94, 98, 102, 106, 110, 114, 118, 122, 126, 130, 134, 138, 142, 146, 150, 154, 158, 162, 166, 170, 174, 178, 182, 186, 190, 194, 198, 202, 206, 210, 214, 218, 222, 226, 230 };
        }
    }

    public class Stock
    {

        public string Name { get; set; }
        public uint Dividend { get; set; }
        public uint[] Prices { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

        public static Stock Woolsworth
        {
            get
            {
                return new Stock()
                {
                    Name = "Woolsworth",
                    Dividend = 4,
                    Prices = new uint[51] {30,34,38,42,46,50,54,58,62,66,70,74,78,82,86,90,94,98,102,106,110,114,118,122,126,130,134,138,142,146,150,154,158,162,166,170,174,178,182,186,190,194,198,202,206,210,214,218,222,226,230 }
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
                    Prices = new uint[51] { 230, 226, 222, 218, 214, 210, 206, 202, 198, 194, 190, 186, 182, 178, 174, 170, 166, 162, 158, 154, 150, 146, 142, 138, 134, 130, 126, 122, 118, 114, 110, 106, 102, 98, 94, 90, 86, 82, 78, 74, 70, 66, 62, 58, 54, 50, 46, 42, 38, 34, 30 }

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
                    Prices = new uint[51] { 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 96, 98, 100, 102, 104, 106, 108, 110 }

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
                    Prices = new uint[51] { 110, 108, 106, 104, 102, 100, 98, 96, 94, 92, 90, 88, 86, 84, 82, 80, 78, 76, 74, 72, 70, 68, 66, 64, 62, 60, 58, 56,54, 52, 50, 48, 46, 44, 42, 40, 38, 36,34, 32, 30, 28, 26, 24, 22, 20, 18, 16, 14, 12, 10 }

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
                    Prices = new uint[51] { 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75 }

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
                    Prices = new uint[51] { 75, 74, 73, 72, 71, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 60, 59, 58, 57, 56, 55, 53, 51, 49, 47, 45, 43, 41, 39, 37, 35,34 , 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15 }

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
                    Prices = new uint[51] { 18, 18, 19, 19, 20, 20, 21, 21, 22, 22, 23, 23, 24, 24, 25, 25, 26, 26, 27, 27, 28, 28, 29, 29, 30, 30, 30, 31, 31, 32, 32, 33, 33, 34, 34, 35, 35, 36, 36, 37, 37, 38, 38, 39, 39, 40, 40, 41, 41, 42, 42 }

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
                    Prices = new uint[51] { 42, 42, 41, 41, 40, 40, 39, 39, 38, 38, 37, 37, 36, 36, 35, 35, 34, 34, 33, 33, 32, 32, 31, 31, 30, 30, 30, 29, 29, 28, 28, 27, 27, 26, 26, 25, 25, 24, 24, 23, 23, 22, 22, 21, 21, 20, 20, 19, 19, 18, 18 }

                };
            }
        }

    }
}
