using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class T86_Partition
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode node1 = new ListNode();
            ListNode pHead1 = node1;
            ListNode node2 = new ListNode();
            ListNode pHead2 = node2;

            while (head != null)
            {
                if (head.val < x)
                {
                    node1.next = head;
                    node1 = node1.next;
                }
                else 
                {
                    node2.next = head;
                    node2 = node2.next;
                }
                head = head.next;
            }
            node2.next = null;
            node1.next = pHead2.next;
            return pHead1.next;
        }
    }
}
