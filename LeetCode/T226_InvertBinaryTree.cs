using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class T226_InvertBinaryTree
    {
        public TreeNode InvertTree1(TreeNode root)
        {
            if (root == null)
                return null;

            var left = InvertTree1(root.left);
            var right = InvertTree1(root.right);
            root.left = right;
            root.right = left;
            return root;
        }
    }
}
