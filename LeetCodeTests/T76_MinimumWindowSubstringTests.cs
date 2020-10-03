using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T76_MinimumWindowSubstringTests
    {
        [TestMethod()]
        [DataRow("ADOBECODEBANC", "ABC", "BANC")]
        public void MinWindowTest(string s, string t, string expected)
        {
            T76_MinimumWindowSubstring t76_MinimumWindow = new T76_MinimumWindowSubstring();
            var result = t76_MinimumWindow.MinWindow(s, t);
            Assert.AreEqual(expected, result);
        }
    }
}