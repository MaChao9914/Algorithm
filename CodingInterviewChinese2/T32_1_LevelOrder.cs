using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T32_1_LevelOrder
    {
        public int[] LevelOrder(TreeNode root)
        {
            List<int> ans = new List<int>();
            Queue<TreeNode> trees = new Queue<TreeNode>();
            if(root != null)
                trees.Enqueue(root);

            while (trees.Count != 0)
            {
                var temp = trees.Dequeue();
                ans.Add(temp.val);

                if(temp.left != null)
                    trees.Enqueue(temp.left);

                if(temp.right != null)
                    trees.Enqueue(temp.right);
            }
            return ans.ToArray();
        }
    }
}
