using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T142_LinkedListCycleIITests
    {
        [TestMethod()]
        [DataRow(new int[] { 3, 2, 0, -4 }, 1, DisplayName = "test1")]
        [DataRow(new int[] { 1, 2 }, 0, DisplayName = "test2")]
        [DataRow(new int[] { 1 }, -1, DisplayName = "test3")]
        public void DetectCycle1Test(int[] input, int expected)
        {
            var head = GetCycleListNode(input, expected);
            T142_LinkedListCycleII listCycleII = new T142_LinkedListCycleII();
            var node = listCycleII.DetectCycle2(head);
            var pos = GetPos(head, node);
            Assert.AreEqual(expected, pos);
        }

        public static ListNode GetCycleListNode(int[] input, int pos)
        {
            ListNode head = new ListNode(0);
            ListNode tail = head;
            ListNode node = null;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == pos)
                    node = tail;

                tail.val = input[i];
                if (i < input.Length - 1)
                {
                    tail.next = new ListNode(0);
                }
                else if(i == input.Length - 1)
                {
                    tail.next = node;
                }
                tail = tail.next;
            }
            return head;
        }

        public static int GetPos(ListNode head, ListNode node)
        {
            int pos = 0;
            while (head != null) 
            {
                if (head == node)
                    return pos;
                head = head.next;
                pos++;
            }
            return -1;
        }
    }
}