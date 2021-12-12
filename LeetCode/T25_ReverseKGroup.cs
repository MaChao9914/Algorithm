using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T25_ReverseKGroup
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || head.next == null)
                return head;
            ListNode node = new ListNode();
            node.next = head;
            ListNode ans = node;
            while (node.next != null)
            {
                ListNode tempHead = node.next;
                ListNode tail = tempHead;
                for (int i = 1; i < k; i++)
                {
                    tail = tail.next;
                    if (tail == null)
                        return ans.next;
                }
                var next = tail.next;
                node.next = ReverseNode(tempHead, tail);
                tempHead.next = next;//经过旋转，昔日头已经变成尾了
                node = tempHead;
            }
            return ans.next;
        }

        ListNode ReverseNode(ListNode head, ListNode tail)
        {
            ListNode previous = null;
            while (head != tail)
            {
                ListNode next = head.next;
                head.next = previous;
                previous = head;
                head = next;
            }
            head.next = previous;
            previous = head;
            return previous;
        }
    }
}
