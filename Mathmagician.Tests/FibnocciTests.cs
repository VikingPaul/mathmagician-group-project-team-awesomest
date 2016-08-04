using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FibnocciTests
    {

        [TestMethod]
        public void SingleNumFibnocciTest1()
        {
            Fibonacci fib = new Fibonacci();
            int[] answer5= fib.PrintFib(5);
            Assert.AreEqual(1, answer5[0]);    
        }

        [TestMethod]
        public void SingleNumFibnocciTest2()
        {
            Fibonacci fib = new Fibonacci();
            int[] answer6 = fib.PrintFib(6);
            Assert.AreEqual(5, answer6[4]);
        }

    }
}
