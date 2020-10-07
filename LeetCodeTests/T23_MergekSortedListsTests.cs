using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T23_MergekSortedListsTests
    {
        [TestMethod()]
        public void MergeKListsTest()
        {
            var input1 = new int[][] { new int[] { 1, 4, 5 }, new int[] { 1, 3, 4 }, new int[] { 2, 6 } };
            var output1 = new int[] { 1, 1, 2, 3, 4, 4, 5, 6 };
            var actual = Merge(input1);
            bool isEqual = output1.SequenceEqual(actual);
            Assert.AreEqual(true, isEqual, "test1");

            var intput2 = new int[0][] { };
            var output2 = new int[0];
            actual = Merge(intput2);
            isEqual = output2.SequenceEqual(actual);
            Assert.AreEqual(true, isEqual, "test2");

            var intput3 = new int[1][] { new int[0]{ } };
            var output3 = new int[0];
            var actual3 = Merge(intput3);
            isEqual = output3.SequenceEqual(actual3);
            Assert.AreEqual(true, isEqual, "test3");
        }

        public static int[] Merge(int[][] input)
        {
            var lists = GetListNodes(input);
            T23_MergekSortedLists t23_MergekSortedLists = new T23_MergekSortedLists();
            
            var ans = t23_MergekSortedLists.MergeKLists2(lists);
            
            var actual = T2_AddTwoNumbersTests.ListNodeToArray(ans);
            return actual;
        }

        public static ListNode[] GetListNodes(int[][] input)
        {
            List<ListNode> lists = new List<ListNode>();

            foreach (var item in input)
            {
                var temp = T2_AddTwoNumbersTests.GetListNode(item);
                if (temp.val == 0 && temp.next == null)
                    continue;
                lists.Add(temp);
            }

            return lists.ToArray();
        }
    }
}