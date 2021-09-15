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
    public class T58_ReverseLeftWordsTests
    {
        [TestMethod()]
        [DataRow("abcdefg", 2, "cdefgab")]
        [DataRow("lrloseumgh", 6, "umghlrlose")]
        public void ReverseLeftWordsTest(string s, int n, string expected)
        {
            var r = T58_ReverseLeftWords.ReverseLeftWords3(s, n);
            Assert.AreEqual(expected, r);
        }
    }
}