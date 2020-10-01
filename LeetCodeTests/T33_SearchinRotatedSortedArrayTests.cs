using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T33_SearchinRotatedSortedArrayTests
    {
        [TestMethod()]
        [DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        [DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
        public void SearchTest(int[] nums, int target, int expected)
        {
            T33_SearchinRotatedSortedArray t33_SearchinRotatedSortedArray = new T33_SearchinRotatedSortedArray();
            var result = t33_SearchinRotatedSortedArray.Search(nums, target);
            Assert.AreEqual(expected, result);
        }
    }
}