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
        [DataRow(new int[] { 2, 3, 5 }, 8, "[[2,2,2,2],[2,3,3],[3,5]]", DisplayName ="test1")]
        [DataRow(new int[] { 2, 3, 6, 7 }, 7, "[[2,2,3],[7]]", DisplayName = "test2")]
        public void CombinationSumTest(int[] candidates, int target, string expect)
        {
            //int[] candidates = new int[] { 2, 3, 5 };//{ 2, 3, 6, 7 };
            //int target = 8;//7;
            T39_CombinationSum t39_CombinationSum = new T39_CombinationSum();
            var result = t39_CombinationSum.CombinationSum(candidates, target);
            Assert.AreEqual(expect, result, "fail");
        }
    }
}