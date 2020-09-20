using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T15_ThreeSumTests
    {
        [TestMethod()]
        [DataRow(new int[] { -1, 0, 1, 2, -1, -4 })]
        public void ThreeSumTest(int[] nums)
        {
            T15_ThreeSum t15_ThreeSum = new T15_ThreeSum();
            var result = t15_ThreeSum.ThreeSum(nums);
        }
    }
}