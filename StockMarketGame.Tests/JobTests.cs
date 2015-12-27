using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame.Tests
{
    [TestFixture]
    public class JobTests
    {
        [Test]
        public static void PoliceManTest()
        {
            Job policeMan = new PoliceMan();
            Assert.AreEqual(policeMan.Salary, 100);
            Assert.IsTrue(policeMan.payoutNumber.Contains(5));
            Assert.IsTrue(policeMan.payoutNumber.Contains(9));
        }

        [Test]
        public static void DoctorTest()
        {
            Job doctor = new Doctor();
            Assert.AreEqual(doctor.Salary, 200);
            Assert.IsTrue(doctor.payoutNumber.Contains(4));
            Assert.IsTrue(doctor.payoutNumber.Contains(10));
        }

        [Test]
        public static void DeepSeaDiverTest()
        {
            Job deepSeaDiver = new DeepSeaDiver();
            Assert.AreEqual(deepSeaDiver.Salary, 300);
            Assert.IsTrue(deepSeaDiver.payoutNumber.Contains(3));
            Assert.IsTrue(deepSeaDiver.payoutNumber.Contains(11));
        }

        [Test]
        public static void ProspectorTest()
        {
            Job prospector = new Prospector();
            Assert.AreEqual(prospector.Salary, 400);
            Assert.IsTrue(prospector.payoutNumber.Contains(2));
            Assert.IsTrue(prospector.payoutNumber.Contains(12));
        }
    }
}
