using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T22_GetKthFromEnd
    {
        public ListNode GetKthFromEnd(ListNode head, int k)
        {
            if (head == null || k == 0)//本题强调了从1开始计数
                return null;

            ListNode p1 = head, p2 = head;
            for (int i = 1; i < k; i++)
            {
                p2 = p2.next;
                if (p2 == null)//防止k大于链表长度
                    return null;
            }
            while(p2.next != null)
            {
                p1 = p1.next;
                p2 = p2.next;
            }
            return p1;
        }
    }
}
