using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T617_MergeTwoBinaryTreesTests
    {
        [TestMethod()]
        public void MergeTreesTest()
        {
            var input1 = new int?[] { 1, 3, 2, 5 };
            var input2 = new int?[] { 2, 1, 3, null, 4, null, 7 };
            var expected = new int?[] { 3, 4, 5, 5, 4, null, 7 };
            TreeNode root1 = T104__MaximumDepthofBinaryTreeTests.GetTree(input1);
            TreeNode root2 = T104__MaximumDepthofBinaryTreeTests.GetTree(input2);

            T617_MergeTwoBinaryTrees t617_Merge = new T617_MergeTwoBinaryTrees();
            var result = t617_Merge.MergeTrees2(root1, root2);
            var actual = T104__MaximumDepthofBinaryTreeTests.TreeNode2Arr(result);
            bool isEqual = expected.SequenceEqual(actual);
            Assert.AreEqual(true, isEqual);
        }
    }
}