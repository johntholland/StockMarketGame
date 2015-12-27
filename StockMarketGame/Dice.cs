using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public static class Dice
    {
        static Random randomGenerator = new Random();

        public static int Roll()
        {
            return randomGenerator.Next(1, 7);
        }
    }
}
