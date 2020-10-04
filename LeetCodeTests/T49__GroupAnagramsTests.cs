using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T49__GroupAnagramsTests
    {
        [TestMethod()]
        [DataRow(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" })]
        public void GroupAnagrams1Test(string[] strs)
        {
            T49__GroupAnagrams t49__Group = new T49__GroupAnagrams();
            var result = t49__Group.GroupAnagrams1(strs);
        }

        [TestMethod()]
        [DataRow(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" })]
        public void GroupAnagrams2Test(string[] strs)
        {
            T49__GroupAnagrams t49__Group = new T49__GroupAnagrams();
            var result = t49__Group.GroupAnagrams2(strs);
        }
    }
}