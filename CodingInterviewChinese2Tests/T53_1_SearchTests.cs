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
    public class T53_1_SearchTests
    {
        [TestMethod()]
        [DataRow(new int[] {1}, 0,0)]
        [DataRow(new int[] { 1 }, 1,1)]

        public void SearchTest(int[] input, int target, int expected)
        {
            var r = T53_1_Search.Search(input, target);
            Assert.AreEqual(expected, r);
        }
    }
}