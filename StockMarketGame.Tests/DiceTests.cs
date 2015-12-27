using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame.Tests
{
    [TestFixture]
    public class DiceTests
    {
        [Test]
        public static void DiceRollDefault()
        {
            for (int i = 0; i < 15; i++)
            {
                var rollResult =Dice.Roll();
                Assert.IsTrue(rollResult < 7);
                Assert.IsTrue(rollResult > 0);
            }
        }
    }
}
