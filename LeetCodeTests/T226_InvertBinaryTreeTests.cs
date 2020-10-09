using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T226_InvertBinaryTreeTests
    {
        [TestMethod()]
        //[DataRow(new int[] { 4,2,7,1,3,6,9}, new int[] {4,7,2,9,6,3,1 })]
        public void InvertTreeTest()
        {
            var input = new int?[] { 4, 2, 7, 1, 3, 6, 9 };
            var expected = new int?[] { 4, 7, 2, 9, 6, 3, 1 };
            TreeNode root = T104__MaximumDepthofBinaryTreeTests.GetTree(input);

            T226_InvertBinaryTree t226_InvertBinaryTree = new T226_InvertBinaryTree();
            var ans = t226_InvertBinaryTree.InvertTree1(root);
            var arr = T104__MaximumDepthofBinaryTreeTests.TreeNode2Arr(ans);
            bool isEqual = expected.SequenceEqual(arr);
            Assert.AreEqual(true, isEqual);
        }
    }
}