using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace LeetCode
{
    public class T23_MergekSortedLists
    {
        /// <summary>
        /// 顺序合并
        /// </summary>
        /// <param name="lists"></param>
        /// <returns></returns>
        public ListNode MergeKLists1(ListNode[] lists)
        {
            ListNode ans = null;

            foreach (var item in lists)
            {
                ans = MergeTwoLists(ans, item);
            }
            return ans;
        }

        /// <summary>
        /// 分而治之
        /// </summary>
        /// <param name="lists"></param>
        /// <returns></returns>
        public ListNode MergeKLists2(ListNode[] lists)
        {
            ListNode ans = null;
            if (lists == null || lists.Length == 0)
            {
                return ans;
            }

            ans = MergeTwoLists(lists, 0, lists.Length - 1);

            return ans;
        }

        public ListNode MergeTwoLists(ListNode[] lists, int left, int right)
        {
            if (left == right)
                return lists[left];

            int mid = (left + right) / 2;
            ListNode listNode1 = MergeTwoLists(lists, left, mid);
            ListNode listNode2 = MergeTwoLists(lists, mid + 1, right);
            return MergeTwoLists(listNode1, listNode2);
        }

        public ListNode MergeTwoLists(ListNode a, ListNode b)
        {
            if (a == null || b == null)
                return a ?? b;

            ListNode head = new ListNode(0);
            ListNode current = head;
            while(a != null && b != null)
            {
                if (a.val < b.val)
                {
                    current.next = a;
                    a = a.next;
                }
                else
                {
                    current.next = b;
                    b = b.next;
                }
                current = current.next;
            }

            current.next = a ?? b;
            return head.next;
        }
    }
}
