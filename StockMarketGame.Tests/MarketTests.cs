using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame.Tests
{
    [TestFixture]
    public class MarketTests
    {
        [Test]
        public static void NormalMarketMovement()
        {
            Market market = new Market();

            var originalIndex = market.Index;

            market.Move(-1);

            Assert.AreEqual(originalIndex - 1, market.Index);
        }

        [Test]
        public static void BounceOffTopMarketMovement()
        {
            Market market = new Market();

            market.Move(25);

            Assert.AreEqual(50, market.Index);

            market.Move(10);

            Assert.AreEqual(40, market.Index);
        }

        [Test]
        public static void BounceOffBottomMarketMovement()
        {
            Market market = new Market();

            market.Move(-25);

            Assert.AreEqual(0, market.Index);

            market.Move(-10);

            Assert.AreEqual(10, market.Index);
        }

    }
}
