using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T105_BuildTree
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0 || inorder.Length == 0)
                return null;
            int rootValue = preorder[0];
            int index = Array.IndexOf(inorder, rootValue);
            TreeNode tree = new TreeNode(rootValue);
            tree.left = BuildTree(preorder.Skip(1).Take(index).ToArray(), inorder.Take(index).ToArray());
            tree.right = BuildTree(preorder.Skip(index + 1).ToArray(), inorder.Skip(index + 1).ToArray());
            return tree;
        }
    }
}
