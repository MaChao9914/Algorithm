using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T24_ReverseList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode node = head;
            ListNode previous = null;

            while (node != null)
            {
                ListNode next = node.next;
                node.next = previous;
                previous = node;
                node = next;
            }

            return previous;
        }
    }
}
