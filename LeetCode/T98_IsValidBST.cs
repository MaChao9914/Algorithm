using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T98_IsValidBST
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
                return true;

            return IsValidBST(root, long.MinValue, long.MaxValue);
        }

        private bool IsValidBST(TreeNode root, long lower, long upper)
        {
            if (root == null)
                return true;

            if (root.val <= lower || root.val >= upper)
                return false;

            return IsValidBST(root.left, lower, root.val)
                   && IsValidBST(root.right, root.val, upper);
        }
    }
}
