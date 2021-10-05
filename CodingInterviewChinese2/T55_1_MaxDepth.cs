using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T55_1_MaxDepth
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            int left = 1 + MaxDepth(root.left);
            int right = 1 + MaxDepth(root.right);
            return left > right ? left : right;
        }
    }
}
