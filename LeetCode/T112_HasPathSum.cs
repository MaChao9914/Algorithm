using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T112_HasPathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;
            if (targetSum == root.val && root.left == null && root.right == null)
                return true;
            
            return HasPathSum(root.left, targetSum - root.val)
                   || HasPathSum(root.right, targetSum - root.val);
        }
    }
}
