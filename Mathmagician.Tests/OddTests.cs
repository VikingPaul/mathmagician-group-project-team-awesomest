using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class OddTests
    {
        // Checks to see that Odd class isn't null
        [TestMethod]
        public void Odd_EnsureICanCreateAnInstance()
        {
            //arrange (nothing in this case)

            //act (nothing in this case)

            //assert
            Assert.IsNotNull(new Odd());
        }

        // Makes a new instance of Odd, runs the CountOddNumbers method with "4" as the input and looks to see if a List<int> is returned
        [TestMethod]
        public void Odd_IsAListReturned()
        {
            //arrange (nothing in this case)

            //act (nothing in this case)

            //assert
            Assert.IsInstanceOfType(new Odd().CountOddNumbers(4), typeof(List<int>));
        }

        // Makes a new instance of Odd, runs the CountOddNumbers method with "15" as the input and looks at compares element 14 to what the 14th odd number should be
        [TestMethod]
        public void Odd_IsTheFifteenthNumberCorrect()
        {
            //arrange (nothing in this case)

            //act (nothing in this case)

            //assert
            Assert.AreEqual(29, new Odd().CountOddNumbers(15)[14]);
        }

        // Makes a new instance of Odd, runs the CountOddNumbers method with "10000" as the input and looks at compares element 14 to what the 14th odd number should be
        [TestMethod]
        public void Odd_IsTheFiveThousanthNumberCorrect()
        {
            //arrange (nothing in this case)

            //act (nothing in this case)

            //assert 
            Assert.AreEqual(9999, new Odd().CountOddNumbers(10000)[4999]);
        }

        // Checks to make sure the correct number of numbers are being reported
        [TestMethod]
        public void Odd_ReturnedListLength()
        {
            //arrange (nothing in this case)

            //act (nothing in this case)

            //assert 
            Assert.AreEqual(10000, new Odd().CountOddNumbers(10000).Count);
        }
    }
}
