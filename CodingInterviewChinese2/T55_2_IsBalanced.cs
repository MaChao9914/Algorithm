using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T55_2_IsBalanced
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;

            return IsBalancedCore(root) != -1;
        }
        int IsBalancedCore(TreeNode node)
        {
            if (node == null)
                return 0;

            int left = IsBalancedCore(node.left);
            if (left == -1)
                return -1;
            int right = IsBalancedCore(node.right);
            if (right == -1)
                return -1;
            int diff = Math.Abs(left - right);
            int max = Math.Max(left, right);
            return diff <= 1 ? max + 1 : -1;
        }
    }
}
