using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T61_RotateRight
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || k == 0 || head.next == null)
                return head;

            int length = 1;
            int move = 0;
            ListNode node = head;
            while (node.next != null)
            {
                length++;
                node = node.next;
            }
            move = k > length ? k % length : k;
            node.next = head;
            for (int i = 0; i < length - move; i++)
            {
                node = node.next;
            }
            ListNode ans = node.next;
            node.next = null;
            return ans;
        }
    }
}
