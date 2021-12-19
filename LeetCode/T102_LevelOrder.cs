using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T102_LevelOrder
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> ans = new List<IList<int>>();
            if (root == null)
                return ans;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Count != 0)
            {
                int length = queue.Count;
                List<int> temp = new List<int>();
                for (int i = 0; i < length; i++)
                {
                    var node = queue.Dequeue();
                    temp.Add(node.val);
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                ans.Add(temp);
            }
            return ans;
        }
    }
}
