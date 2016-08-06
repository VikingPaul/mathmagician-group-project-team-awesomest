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
            int[] answer1= fib.PrintFib(23);
            Assert.AreEqual(28657, answer1[22]);    
        }

        [TestMethod]
        public void SingleNumFibnocciTest2()
        {
            Fibonacci fib = new Fibonacci();
            int[] answer2 = fib.PrintFib(17);
            Assert.AreEqual(1597, answer2[16]);
        }

        [TestMethod]
        public void FibTestLength()
        {
            Fibonacci fib = new Fibonacci();
            int[] answer3 = fib.PrintFib(12);
            Assert.AreEqual(12, answer3.Length);
        }

    }
}
