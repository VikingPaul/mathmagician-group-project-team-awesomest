using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimeTest
    {
        [TestMethod]
        public void Prime0()
        {
            Assert.IsNotNull(new Prime(1));
        }
        [TestMethod]
        public void Prime1()
        {
            Assert.IsInstanceOfType(new Prime(1).PrimeList(), typeof(List<int>));
        }
        [TestMethod]
        public void Prime2()
        {
            Prime num = new Prime(1);
            Assert.IsTrue(2 == num.PrimeList()[0]);
        }
        [TestMethod]
        public void Prime3()
        {
            Prime num = new Prime(100);
            Assert.AreEqual(541, num.PrimeList()[99]);
        }
    }
}
