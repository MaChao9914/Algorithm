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
    public class T16_ThreeSumClosestTests
    {
        [TestMethod()]
        [DataRow(new int[] {1, 1, -1, -1, 3}, -1)]
        public void ThreeSumClosestTest(int[] nums, int target)
        {
            T16_ThreeSumClosest.ThreeSumClosest(nums, target);
        }
    }
}