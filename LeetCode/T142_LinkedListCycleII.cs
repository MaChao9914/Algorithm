using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class T142_LinkedListCycleII
    {
        /// <summary>
        /// 哈希表
        /// 算法复杂度：O(n)；空间复杂度：O(n)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DetectCycle1(ListNode head)
        {
            ListNode node = head;
            List<ListNode> lists = new List<ListNode>();
            while(node != null)
            {
                if (lists.Contains(node))
                    return node;

                lists.Add(node);
                node = node.next;
            }

            return null;
        }
        /// <summary>
        /// Floyd 算法
        /// 先找相遇点，然后再找到环入口
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DetectCycle2(ListNode head)
        {
            if (head == null)
                return null;

            ListNode intersect = GetIntersect(head);
            if (intersect == null)
                return null;

            ListNode ptr1 = head;
            ListNode ptr2 = intersect;
            while(ptr1 != ptr2)
            {
                ptr1 = ptr1.next;
                ptr2 = ptr2.next;
            }
            return ptr1;
        }
        /// <summary>
        /// 快慢指针求相遇点
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        private ListNode GetIntersect(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)//注意条件
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                    return slow;
            }
            return null;
        }
    }
}
