using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class T104__MaximumDepthofBinaryTree
    {
        /// <summary>
        /// 递归
        /// 时间复杂度O(n),其中n为二叉树节点的个数。每个节点在递归中只被遍历一次
        /// 空间复杂度，O(h),h表示二叉树的深度，递归函数需要栈空间，而栈空间取决于递归的深度，因此空间复杂度等价于二叉树的高度。
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth1(TreeNode root)
        {
            int depth = 0;
            if (root == null)
                return depth;

            int lDepth = MaxDepth1(root.left);
            int rDepth = MaxDepth1(root.right);
            depth = Math.Max(lDepth, rDepth) + 1;

            return depth;
        }
        /// <summary>
        /// 广度优先搜索
        /// 时间复杂度O(n),其中n为二叉树节点的个数。每个节点在递归中只被遍历一次
        /// 空间复杂度，此方法空间的消耗取决于队列存储的元素数量，其在最坏情况下会达到 O(n)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth2(TreeNode root)
        {
            int depth = 0;
            if (root == null)
                return depth;

            Queue<TreeNode> trees = new Queue<TreeNode>();
            trees.Enqueue(root);
            int count = trees.Count;//表示某一层的所有节点数
            while (count != 0)
            {
                while (count > 0)
                {
                    var node = trees.Dequeue();
                    if (node.left != null)
                        trees.Enqueue(node.left);
                    if (node.right != null)
                        trees.Enqueue(node.right);
                    count--;
                }
                count = trees.Count;

                depth++;
            }

            return depth;
        }
    }
}
