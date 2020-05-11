using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T1_TwoSumTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            T1_TwoSum t1_TwoSum = new T1_TwoSum();

            var result = t1_TwoSum.TwoSum(nums, target);

            Assert.AreNotEqual(null, result);
        }
    }
}