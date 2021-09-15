using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T35_CopyRandomList
    {
        public static Node CopyRandomList(Node head)
        {
            if (head == null)
                return null;

            Node clone = head;
            //复制链表，只考虑next
            while (clone != null)
            {
                Node temp = new Node(clone.val);
                temp.next = clone.next;
                temp.random = null;

                clone.next = temp;
                clone = temp.next;
            }
            //考虑random
            clone = head;
            while(clone != null)
            {
                if (clone.random != null)
                {
                    clone.next.random = clone.random.next;
                }
                clone = clone.next.next;
            }

            //拆链表
            clone = head;
            Node ansHead = clone.next;
            //if (clone != null)
            //{
            //    ans = clone.next;
            //    ansHead = ans;

            //    clone.next = clone.next.next;//复原输入链表
            //    clone = clone.next;
            //}
            while (clone != null)
            {
                Node ans = clone.next;
                clone.next = clone.next.next;//复原输入链表
                clone = clone.next;
                ans.next = clone != null ? clone.next : null;
            }

            return ansHead;
        }

        public Node CopyRandomList1(Node head)
        {
            if (head == null)
            {
                return null;
            }
            for (Node node = head; node != null; node = node.next.next)
            {
                Node nodeNew = new Node(node.val);
                nodeNew.next = node.next;
                node.next = nodeNew;
            }
            for (Node node = head; node != null; node = node.next.next)
            {
                Node nodeNew = node.next;
                nodeNew.random = (node.random != null) ? node.random.next : null;
            }
            Node headNew = head.next;
            for (Node node = head; node != null; node = node.next)
            {
                Node nodeNew = node.next;
                node.next = node.next.next;
                nodeNew.next = (nodeNew.next != null) ? nodeNew.next.next : null;
            }
            return headNew;
        }

        Dictionary<Node, Node> cachedNode = new Dictionary<Node, Node>();
        public Node CopyRandomList2(Node head)
        {
            if (head == null)
            {
                return null;
            }
            if (!cachedNode.ContainsKey(head))
            {
                Node headNew = new Node(head.val);
                cachedNode.Add(head, headNew);
                headNew.next = CopyRandomList2(head.next);
                headNew.random = CopyRandomList2(head.random);
            }
            return cachedNode[head];
        }
    }
}
