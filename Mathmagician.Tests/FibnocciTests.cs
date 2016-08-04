using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public void ThisIsNotATest()
        {

        }

        [TestMethod]
        public void TestThatThisIsTrue()
        {
            //arrange
            //act
            //assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ThisShouldFail()
        {
            //arrange
            //act
            //assert
            Assert.Fail();
        }

  
        
    }
}
