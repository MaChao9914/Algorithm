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
    public class T30_FindSubstringTests
    {
        [TestMethod()]
        [DataRow(new string[] { "word", "good", "best", "good" }, "wordgoodgoodgoodbestword")]
        [DataRow(new string[] { "fooo", "barr", "wing", "ding", "wing" }, "lingmindraboofooowingdingbarrwingmonkeypoundcake")]
        public void FindSubstringTest(string[] words, string s)
        {
            T30_FindSubstring.FindSubstring(s, words);
        }
    }
}