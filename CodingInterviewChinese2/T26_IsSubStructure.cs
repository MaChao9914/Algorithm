using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T26_IsSubStructure
    {
        public bool IsSubStructure(TreeNode A, TreeNode B)
        {
            if (A == null || B == null)
                return false;

            bool result = false;

            if (A.val == B.val)
                result = IsTreeAHasTreeB(A, B);
            if (!result)
                result = IsSubStructure(A.left, B);
            if (!result)
                result = IsSubStructure(A.right, B);
            return result;
        }

        private bool IsTreeAHasTreeB(TreeNode A, TreeNode B)
        {
            if (B == null)
                return true;
            if (A == null)
                return false;
            if (A.val != B.val)
                return false;

            return IsTreeAHasTreeB(A.left, B.left) && IsTreeAHasTreeB(A.right, B.right);
        }
    }
}
