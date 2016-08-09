using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void IntIfNotNull()
        {
            Integer int1 = new Integer();
            int[] answer1 = int1.PrintInteger(4);
            Assert.IsNotNull(answer1);

        }

        [TestMethod]
        public void testIntType()
        {
            Integer int2 = new Integer();
            int[] answer2 = int2.PrintInteger(100);
            Assert.AreEqual(typeof(Int32), answer2[80].GetType());
        }

        [TestMethod]
        public void testIntSingleNum()
        {
            Integer int3 = new Integer();
            int[] answer3 = int3.PrintInteger(50);
            Assert.AreEqual(44, answer3[44]);
        }

        [TestMethod]
        public void testIntSingleNum2()
        {
            Integer int4 = new Integer();
            int[] answer4 = int4.PrintInteger(100);
            Assert.AreEqual(98, answer4[98]);
        }

        [TestMethod]
        public void testIntLength()
        {
            Integer int5 = new Integer();
            int[] answer5 = int5.PrintInteger(40);
            Assert.AreEqual(40, answer5.Length);
        }

        [TestMethod]
        public void IntWholeArrayTest()
        {
            Integer int6 = new Integer();
            int[] answer6 = int6.PrintInteger(7);
            int[] expectedArray = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            CollectionAssert.AreEqual(answer6, expectedArray);
        }


    }
}
