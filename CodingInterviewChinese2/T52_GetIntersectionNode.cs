using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T52_GetIntersectionNode
    {
        public ListNode GetIntersectionNode1(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            Stack<ListNode> nodesA = new Stack<ListNode>();
            Stack<ListNode> nodesB = new Stack<ListNode>();

            while (headA != null || headB != null)
            {
                if (headA != null)
                {
                    nodesA.Push(headA);
                    headA = headA.next;
                }

                if(headB != null)
                {
                    nodesB.Push(headB);
                    headB = headB.next;
                }
            }

            while(nodesA.Count() != 0 && nodesB.Count() != 0)
            {
                var a = nodesA.Pop();
                var isANext = nodesA.TryPeek(out ListNode aNext);
                var b = nodesB.Pop();
                var isBNext = nodesB.TryPeek(out ListNode bNext);
                if (a == b && (aNext != bNext || !isANext && !isBNext))
                    return a;
            }
            return null;
        }

        public ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            int headALength = GetListNodeLength(headA);
            int headBLength = GetListNodeLength(headB);

            int lengthDif = headALength - headBLength;
            if(lengthDif > 0)
            {
                for (int i = 0; i < lengthDif; i++)
                {
                    headA = headA.next;
                }
            }
            else
            {
                for (int i = 0; i < Math.Abs(lengthDif); i++)
                {
                    headB = headB.next;
                }
            }
            while (headA !=null && headB!=null)
            {
                if (headA == headB)
                    return headA;
                headA = headA.next;
                headB = headB.next; 
            }
            return null;
        }
        int GetListNodeLength(ListNode node)
        {
            int ans = 0;
            while (node != null)
            {
                ans++;
                node = node.next;
            }
            return ans;
        }

        public ListNode GetIntersectionNode3(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }
            ListNode pA = headA, pB = headB;
            while (pA != pB)
            {
                pA = pA == null ? headB : pA.next;
                pB = pB == null ? headA : pB.next;
            }
            return pA;
        }
    }
}
