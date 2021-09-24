using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T28_IsSymmetric
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;
            return IsSymmetric(root, root);
        }

        private bool IsSymmetric(TreeNode A, TreeNode B)
        {
            if (A == null && B == null)
                return true;
            if (A == null || B == null)
                return false;
            if (A.val != B.val)
                return false;

            return IsSymmetric(A.left, B.right) && IsSymmetric(A.right, B.left);
        }
    }
}
