using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimeTest
    {
        [TestMethod]
        public void IsClassNull()
        {
            Assert.IsNotNull(new Prime(1));
        }
        [TestMethod]
        public void IsListList()
        {
            Assert.IsInstanceOfType(new Prime(1).PrimeList(), typeof(List<int>));
        }
        [TestMethod]
        public void IsFirstPrimeTwo()
        {
            Prime num = new Prime(1);
            Assert.IsTrue(2 == num.PrimeList()[0]);
        }
        [TestMethod]
        public void IsHundredthPrimeFiveHundredFourtyOne()
        {
            Prime num = new Prime(100);
            Assert.AreEqual(541, num.PrimeList()[99]);
        }
    }
}
