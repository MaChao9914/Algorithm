using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T31_NextPermutationTests
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 3, 2 })]
        [DataRow(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        public void NextPermutationTest(int[] nums, int[] targets)
        {
            T31_NextPermutation t31_NextPermutation = new T31_NextPermutation();
            t31_NextPermutation.NextPermutation(nums);
            var isEqual= targets.SequenceEqual(nums);
            Assert.AreEqual(true, isEqual);
        }
    }
}