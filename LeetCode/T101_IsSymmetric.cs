using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T101_IsSymmetric
    {
        public bool IsSymmetric(TreeNode root)
        {
            //return DFS(root, root);
            return BFS(root, root);
        }

        private bool BFS(TreeNode rootA, TreeNode rootB)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(rootA);
            queue.Enqueue(rootB);

            while(queue.Count != 0)
            {
                var a = queue.Dequeue();
                var b = queue.Dequeue();
                if (a == null && b == null)
                    continue;
                if (a == null || b == null || a.val != b.val)
                    return false;

                queue.Enqueue(a.left);
                queue.Enqueue(b.right);
                queue.Enqueue(a.right);
                queue.Enqueue(b.left);
            }
            return true;
        }

        private bool DFS(TreeNode rootA, TreeNode rootB)
        {
            if (rootA == null && rootB == null)
                return true;
            if (rootA == null || rootB == null)
                return false;
            if (rootA.val != rootB.val)
                return false;
            return DFS(rootA.left, rootB.right) && DFS(rootA.right, rootB.left);
        }
    }
}
