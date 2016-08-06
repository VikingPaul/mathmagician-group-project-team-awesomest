using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void testIntType()
        {
            Integer int1 = new Integer();
            int[] answer1 = int1.PrintInteger(100);
            Assert.AreEqual(typeof(Int32), answer1[80].GetType());
        }

        [TestMethod]
        public void testIntSingleNum()
        {
            Integer int2 = new Integer();
            int[] answer2 = int2.PrintInteger(50);
            Assert.AreEqual(44, answer2[44]);
        }

        [TestMethod]
        public void testIntSingleNum2()
        {
            Integer int3 = new Integer();
            int[] answer3 = int3.PrintInteger(100);
            Assert.AreEqual(98, answer3[98]);
        }

        [TestMethod]
        public void testIntLength()
        {
            Integer int4 = new Integer();
            int[] answer4 = int4.PrintInteger(40);
            Assert.AreEqual(40, answer4.Length);
        }


    }
}
