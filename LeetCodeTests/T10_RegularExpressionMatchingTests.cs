using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T10_RegularExpressionMatchingTests
    {
        [TestMethod()]
        [DataRow("aa", "a", false, DisplayName = "test1")]
        [DataRow("aa", "a*", true, DisplayName = "test2")]
        [DataRow("ab", ".*", true, DisplayName = "test3")]
        [DataRow("aab", "c*a*b", true, DisplayName = "test4")]
        [DataRow("mississippi", "mis*is*p*.", false, DisplayName = "test5")]
        public void IsMatchTest(string s, string p, bool expected)
        {
            T10_RegularExpressionMatching t10_RegularExpression = new T10_RegularExpressionMatching();
            var ans = t10_RegularExpression.IsMatch(s, p);
            Assert.AreEqual(expected, ans);
        }
    }
}