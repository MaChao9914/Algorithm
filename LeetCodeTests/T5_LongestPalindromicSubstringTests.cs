using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T5_LongestPalindromicSubstringTests
    {
        [TestMethod()]
        [DataRow("babad", "bab")]
        [DataRow("cbbd", "bb")]
        [DataRow("a", "a")]
        [DataRow("ac", "a")]
        public void LongestPalindromeTest(string s, string expected)
        {
            T5_LongestPalindromicSubstring t5_LongestPalindromic = new T5_LongestPalindromicSubstring();
            var result = t5_LongestPalindromic.LongestPalindrome1(s);
            Assert.AreEqual(expected, result);
            result = t5_LongestPalindromic.LongestPalindrome2(s);
            Assert.AreEqual(expected, result);
        }
    }
}