using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T25_MergeTwoLists
    {
        /// <summary>
        /// 迭代
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists1(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;

            ListNode ans = new ListNode(0), temp = ans;
            while(l1 != null && l2 != null)
            {
                if(l1.val <= l2.val)
                {
                    temp.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    temp.next = l2;
                    l2 = l2.next;
                }
                temp = temp.next;
            }
            temp.next = l1 != null ? l1 : l2;
            return ans.next;
        }

        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists2(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            ListNode ans = null;
            if(l1.val <= l2.val)
            {
                ans = l1;
                ans.next = MergeTwoLists2(l1.next, l2);
            }
            else
            {
                ans = l2;
                ans.next = MergeTwoLists2(l1, l2.next);
            }
            return ans;
        }
    }
}
