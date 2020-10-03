using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T3_LongestSubstringWithoutRepeatingCharactersTests
    {
        [TestMethod()]
        [DataRow("abcabcbb", 3)]
        [DataRow("bbbbb", 1)]
        [DataRow("pwwkew", 3)]
        public void LengthOfLongestSubstringTest(string s, int ecpected)
        {
            T3_LongestSubstringWithoutRepeatingCharacters t3_LongestSubstring = new T3_LongestSubstringWithoutRepeatingCharacters();
            var result = t3_LongestSubstring.LengthOfLongestSubstring(s);
            Assert.AreEqual(ecpected, result);
        }
    }
}