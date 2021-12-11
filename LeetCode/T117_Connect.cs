using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class T117_Connect
    {
        public Node Connect(Node root)
        {
            if (root == null)
                return null;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    Node node = queue.Dequeue();
                    if (i < size - 1)
                        node.next = queue.Peek();
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }
            return root;
        }

        //时间复杂度：O(N)，每个节点只访问一次。
        //空间复杂度：O(1)，不需要存储额外的节点。
        public Node Connect2(Node root)
        {
            if (root == null)
                return null;
            Node node = root;
            while (node != null)//纵向遍历每一层
            {
                Node currNode = node;
                Node subStartNode = null;
                Node subNode = subStartNode;
                while (currNode != null)//横向遍历当前层的每一个节点
                {
                    if (subStartNode == null)
                    {
                        subStartNode = currNode.left ?? currNode.right;//初始化下一层的起始节点
                        subNode = subStartNode;
                    }

                    if(subNode != null)
                    {
                        if (subNode == currNode.left && currNode.right != null)
                        {
                            subNode.next = currNode.right;
                            subNode = subNode.next;
                        }
                        if (currNode.next != null)
                        {
                            subNode.next = currNode.next.left ?? currNode.next.right;
                            if (subNode.next != null)
                                subNode = subNode.next;
                        }
                    }
                    currNode = currNode.next;
                }
                node = subStartNode;//下一层的第一个节点
            }
            return root;
        }
    }
}
