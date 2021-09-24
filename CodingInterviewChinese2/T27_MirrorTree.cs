using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T27_MirrorTree
    {
        public TreeNode MirrorTree(TreeNode root)
        {
            if (root == null)
                return null;

            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            MirrorTree(root.left);
            MirrorTree(root.right);

            return root;
        }
    }
}
