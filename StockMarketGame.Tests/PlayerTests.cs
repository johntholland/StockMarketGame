using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame.Tests
{
    [TestFixture()]
    public class PlayerTests
    {
        [Test()]
        public static void BuyDefaultCase()
        {
            Player player1 = new Player("Test");
            player1.Cash = 500;

            player1.Buy(Stock.JICase, 1, 500);

            Assert.AreEqual(player1.Cash, 0);
            Assert.AreEqual(player1.ShareQuantities[Stock.JICase.Name], 1);
        }

        [Test()]
        public static void SellDefaultCase()
        {
            Player player1 = new Player("Test");

            player1.Cash = 0;
            player1.AddStock(Stock.JICase, 1);
            player1.Sell(Stock.JICase, 1, 500);

            Assert.AreEqual(player1.Cash, 500);
            Assert.AreEqual(player1.ShareQuantities[Stock.JICase.Name], 0);
        }

        [Test()]
        public static void SellFailureCase()
        {
            Player player1 = new Player("Test");

            Assert.Throws<NotEnoughStockException>(() => player1.Sell(Stock.JICase, 1, 500));
        }

        [Test()]
        public static void BuyFailureCase()
        {
            Player player1 = new Player("Test");

            Assert.Throws<NotEnoughCashException>(() => player1.Buy(Stock.JICase, 1, 500));
        }
    }
}
