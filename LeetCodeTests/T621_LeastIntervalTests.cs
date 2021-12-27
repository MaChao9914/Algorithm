using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T621_LeastIntervalTests
    {
        [TestMethod()]
        [DataRow(new char[] { 'A', 'B', 'A' }, 2, 4)]
        public void LeastInterval1Test(char[] tasks, int n, int expected)
        {
            var r = T621_LeastInterval.LeastInterval1(tasks, n);
            Assert.AreEqual(expected, r); 
        }
    }
}