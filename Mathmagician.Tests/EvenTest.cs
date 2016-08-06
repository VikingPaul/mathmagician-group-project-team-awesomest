using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTest
    {
        [TestMethod]
        public void IsEvenClassNull()
        {
            Assert.IsNotNull(new Even(1));
        }
        [TestMethod]
        public void IsEvenListList()
        {
            Assert.IsInstanceOfType(new Even(1).EvenList(), typeof(List<int>));
        }
        [TestMethod]
        public void IsEvenListCorrectLength()
        {
            Even num = new Even(5);
            Assert.IsTrue(5 == num.EvenList().Count);
        }
        [TestMethod]
        public void IsFirstEvenTwo()
        {
            Even num = new Even(1);
            Assert.IsTrue(2 == num.EvenList()[0]);
        }
        [TestMethod]
        public void IsFifthEvenTen()
        {
            Even num = new Even(5);
            Assert.IsTrue(10 == num.EvenList()[4]);
        }
    }
}
