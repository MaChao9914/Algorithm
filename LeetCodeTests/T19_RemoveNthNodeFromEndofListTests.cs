using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T19_RemoveNthNodeFromEndofListTests
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 3, 5 }, DisplayName = "test1")]
        [DataRow(new int[] { 1 }, 1, new int[] { }, DisplayName = "test2")]
        [DataRow(new int[] { 1, 2 }, 1, new int[] { 1 }, DisplayName = "test3")]
        public void RemoveNthFromEndTest(int[] input, int n, int[] output)
        {
            var head = T2_AddTwoNumbersTests.GetListNode(input);

            T19_RemoveNthNodeFromEndofList t19_RemoveNthNode = new T19_RemoveNthNodeFromEndofList();
            var ans = t19_RemoveNthNode.RemoveNthFromEnd(head, n);
            var actual = T2_AddTwoNumbersTests.ListNodeToArray(ans);
            bool isEqual = output.SequenceEqual(actual);
            Assert.AreEqual(true, isEqual);
        }


    }
}