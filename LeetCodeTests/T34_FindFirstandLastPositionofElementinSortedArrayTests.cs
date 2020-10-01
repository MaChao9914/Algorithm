using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T34_FindFirstandLastPositionofElementinSortedArrayTests
    {
        [TestMethod()]
        //[DataRow(new int[] { 5, 7, 7, 8, 8, 10 }, 8, new int[] { 3, 4 }, DisplayName = "test1 failed")]
        [DataRow(new int[] { 5, 7, 7, 8, 8, 10 }, 6, new int[] { -1, -1 }, DisplayName = "test2 failed")]
        public void SearchRangeTest(int[] nums, int target, int[] expected)
        {
            T34_FindFirstandLastPositionofElementinSortedArray t34_FindFirstandLast = new T34_FindFirstandLastPositionofElementinSortedArray();
            var result = t34_FindFirstandLast.SearchRange(nums, target);
            bool isEqual = expected.SequenceEqual(result);
            Assert.AreEqual(true, isEqual);
        }
    }
}