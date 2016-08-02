using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            //arrange: nothing in this case

            //act
            Integer my_int = new Integer();//what I want to be able to do

            //assert
            Assert.IsNotNull(my_int);

        }
    }
}
