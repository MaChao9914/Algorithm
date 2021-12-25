using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class T116_Connect
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
                    //将下一层加入队列
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
            while(node.left != null)//遍历每一层
            {
                Node temp = node;
                while(temp != null)//遍历当前层的每一个节点
                {
                    temp.left.next = temp.right;
                    if (temp.next != null)
                    {
                        temp.right.next = temp.next.left;
                    }
                    temp = temp.next;
                }
                node = node.left;
            }
            return root;
        }
    }

    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}
