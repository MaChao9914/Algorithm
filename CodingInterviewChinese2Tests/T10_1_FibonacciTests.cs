using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingInterviewChinese2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2.Tests
{
    [TestClass()]
    public class T10_1_FibonacciTests
    {
        [TestMethod()]
        [DataRow(2,1)]
        public void FibTest(int input, int expected)
        {
            var r = T10_1_Fibonacci.Fib(input);
            Assert.AreEqual(expected, r);
        }
    }
}