using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T18_DeleteNode
    {
        public ListNode DeleteNode(ListNode head, int val)
        {
            if (head == null)
                return null;

            if (head.val == val)
                return head.next;

            ListNode node = head;
            while (node.next != null)
            {
                var nextNode = node.next;
                if (nextNode.val == val)
                {
                    node.next = nextNode.next;
                }
                node = node.next;
                if (node == null)
                    break;
            }

            return head;
        }
    }
}
