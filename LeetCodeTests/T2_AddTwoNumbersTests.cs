using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T2_AddTwoNumbersTests
    {
        [TestMethod()]
        [DataRow(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 }, DisplayName = "test1")]
        [DataRow(new int[] { 0 }, new int[] { 0 }, new int[] { 0 }, DisplayName = "test2")]
        [DataRow(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 }, DisplayName = "test3")]
        public void AddTwoNumbersTest(int[] a1, int[] a2, int[] expected)
        {
            T2_AddTwoNumbers t2_AddTwo = new T2_AddTwoNumbers();

            var l1 = GetListNode(a1);
            var l2 = GetListNode(a2);

            var ans = t2_AddTwo.AddTwoNumbers(l1, l2);
            var actual = ListNodeToArray(ans);
            bool isEqual = expected.SequenceEqual(actual);
            Assert.AreEqual(true, isEqual);
        }

        private int[] ListNodeToArray(ListNode listNode)
        {
            List<int> ans = new List<int>();
            ListNode current = listNode;
            while(current != null)
            {
                var value = current.val;
                ans.Add(value);
                current = current.next;
            }
            return ans.ToArray();
        }

        private ListNode GetListNode(int[] array)
        {
            ListNode ans = new ListNode(0);
            ListNode current = ans;
            
            for (int i = 0; i < array.Length; i++)
            {
                current.val = array[i];
                if (i < array.Length - 1)
                {
                    current.next = new ListNode(0);
                    current = current.next;
                }
            }
            return ans;
        }
    }
}