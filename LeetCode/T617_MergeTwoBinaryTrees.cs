using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LeetCode
{
    public class T617_MergeTwoBinaryTrees
    {
        /// <summary>
        /// 深度优先搜索
        /// 时间复杂度O(min(m,n));空间复杂度O(min(hm,hn))
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public TreeNode MergeTrees1(TreeNode t1, TreeNode t2)
        {
            if (t1 == null || t2 == null)
                return t1 ?? t2;

            TreeNode ans = new TreeNode(t1.val + t2.val);
            ans.left = MergeTrees1(t1.left, t2.left);
            ans.right = MergeTrees1(t1.right, t2.right);
            return ans;
        }

        /// <summary>
        /// 广度优先索索
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public TreeNode MergeTrees2(TreeNode t1, TreeNode t2)
        {
            if (t1 == null || t2 == null)
                return t1 ?? t2;
            TreeNode ans = new TreeNode(t1.val + t2.val);
            Queue<TreeNode> ans_queue = new Queue<TreeNode>();
            Queue<TreeNode> t1_queue = new Queue<TreeNode>();
            Queue<TreeNode> t2_queue = new Queue<TreeNode>();
            ans_queue.Enqueue(ans);
            t1_queue.Enqueue(t1);
            t2_queue.Enqueue(t2);
            while (t1_queue.Count != 0 && t2_queue.Count != 0)
            {
                TreeNode node = ans_queue.Dequeue();//引用类型；node = ans
                TreeNode node1 = t1_queue.Dequeue();
                TreeNode node2 = t2_queue.Dequeue();
                var left1 = node1.left;
                var right1 = node1.right;
                var left2 = node2.left;
                var right2 = node2.right;
                if (left1 != null || left2 != null)
                {
                    if (left1 != null && left2 != null)
                    {
                        node.left = new TreeNode(left1.val + left2.val);
                        ans_queue.Enqueue(node.left);
                        t1_queue.Enqueue(left1);
                        t2_queue.Enqueue(left2);

                    }else if(left1 != null)
                    {
                        node.left = left1;
                    }else if(left2 != null)
                    {
                        node.left = left2;
                    }
                }

                if (right1 != null || right2 != null)
                {
                    if (right1 != null && right2 != null)
                    {
                        node.right = new TreeNode(right1.val + right2.val);
                        ans_queue.Enqueue(node.right);
                        t1_queue.Enqueue(right1);
                        t2_queue.Enqueue(right2);
                    }else if(right1 != null)
                    {
                        node.right = right1;
                    }else if(right2 != null)
                    {
                        node.right = right2;
                    }
                }
            }

            return ans;
        }
    }
}
