using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class T19_RemoveNthNodeFromEndofList
    {
        /// <summary>
        /// 双指针：一遍扫描
        /// 要格外注意链表中第一个节点删除的情况
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode ans = new ListNode(0);
            ans.next = head;//目的是保证原始链表中的第一个节点也能删除

            ListNode left = ans;
            ListNode right = ans;
            int rMove = 0;
            while (right.next != null)//右指针指向最后一个节点时结束循环
            {
                rMove++;
                right = right.next;
                if (rMove > n)
                {
                    left = left.next;
                }
            }
            left.next = left.next.next;
            return ans.next;
        }
    }
}
