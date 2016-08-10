using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FibnocciTests
    {
        [TestMethod]
        public void FibIfNotNull()
        {
            Fibonacci fib = new Fibonacci();
            int[] answer1 = fib.PrintFib(5);
            Assert.IsNotNull(answer1);

        }

        [TestMethod]
        public void SingleNumFibnocciTest1()
        {
            Fibonacci fib = new Fibonacci();
            int[] answer2= fib.PrintFib(23);
            Assert.AreEqual(28657, answer2[22]);    
        }

        [TestMethod]
        public void SingleNumFibnocciTest2()
        {
            Fibonacci fib = new Fibonacci();
            int[] answer3 = fib.PrintFib(17);
            Assert.AreEqual(1597, answer3[16]);
        }

        [TestMethod]
        public void FibTestLength()
        {
            Fibonacci fib = new Fibonacci();
            int[] answer4 = fib.PrintFib(12);
            Assert.AreEqual(12, answer4.Length);
        }

        [TestMethod]
        public void FibWholeArrayTest()
        {
            Fibonacci fib = new Fibonacci();
            int[] answer5 = fib.PrintFib(8);
            int[] expectedArray= new int[]{1, 1, 2, 3, 5, 8, 13, 21};
            CollectionAssert.AreEqual(answer5, expectedArray);

        }

    }
}
