using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T06_ReversePrintList
    {

        public int[] ReversePrint(ListNode head)
        {
            List<int> ans = new List<int>();
            if (head == null)
                return ans.ToArray();
            var temp = ReversePrint(head.next);
            if (temp != null && temp.Length != 0)
                ans.AddRange(temp);
            ans.Add(head.val);
            return ans.ToArray();
        }

        List<int> temp = new List<int>();
        public int[] ReversePrint3(ListNode head)
        {
            Recur(head);
            return temp.ToArray();
        }

        private void Recur(ListNode head)
        {
            if (head == null)
                return;
            Recur(head.next);
            temp.Add(head.val);
        }

        public int[] ReversePrint2(ListNode head)
        {
            Stack<int> ans = new Stack<int>();

            if (head != null)
            {
                ans.Push(head.val);
                while (head.next != null)
                {
                    head = head.next;
                    ans.Push(head.val);
                }
            }
            return ans.ToArray();
        }
    }
}
