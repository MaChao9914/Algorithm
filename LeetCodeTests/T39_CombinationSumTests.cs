using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T39_CombinationSumTests
    {
        [TestMethod()]
        public void CombinationSumTest()
        {
            int[] candidates = new int[] { 2, 3, 5 };//{ 2, 3, 6, 7 };
            int target = 8;//7;
            T39_CombinationSum t39_CombinationSum = new T39_CombinationSum();
            var result = t39_CombinationSum.CombinationSum(candidates, target);
            Assert.AreNotEqual("[[],[]]", result, result);
        }
    }
}