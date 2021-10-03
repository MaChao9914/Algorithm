using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T54_KthLargest
    {
        int _ans;
        int _k;
        public int KthLargest(TreeNode root, int k)
        {
            if (root == null)
                return int.MinValue;
            _k = k;
            KthLargestCore(root);
            return _ans;
        }

        void KthLargestCore(TreeNode root)
        {
            if (root == null)
                return;

            KthLargestCore(root.right);
            if (--_k <= 0)
            {
                if (_k == 0)
                    _ans = root.val;
                return;
            }
            KthLargestCore(root.left);
        }
    }
}
