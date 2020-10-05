using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class T2_AddTwoNumbers
    {
        /// <summary>
        /// 模拟10进制数字相加
        /// 注意l1和l2是逆序的，所以对应位置可以直接相加
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode ans = new ListNode(0);
            ListNode current = ans;

            while (l1 != null || l2 != null)
            {
                int val1 = l1?.val ?? 0;
                int val2 = l2?.val ?? 0;
                int value = (val1 + val2 + current.val) % 10;
                int carray = (val1 + val2 + current.val) / 10;
                current.val = value;

                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;

                if (l1 != null || l2 != null || carray > 0)
                {
                    current.next = new ListNode(carray);
                    current = current.next;
                }
            }
            return ans;
        }
    }
}
