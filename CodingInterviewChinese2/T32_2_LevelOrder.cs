using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T32_2_LevelOrder
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> ans = new List<List<int>>();
            List<int> currentLevel = new List<int>();
            int next = 0;
            int current = 0;

            Queue<TreeNode> trees = new Queue<TreeNode>();
            if (root != null)
            {
                trees.Enqueue(root);
                current += 1;
            }

            while (trees.Count != 0)
            {
                var temp = trees.Dequeue();
                currentLevel.Add(temp.val);
                current -= 1;

                if (temp.left != null)
                {
                    trees.Enqueue(temp.left);
                    next++;
                }

                if (temp.right != null)
                {
                    trees.Enqueue(temp.right);
                    next++;
                }

                if(current == 0)
                {
                    ans.Add(currentLevel);
                    currentLevel = new List<int>();
                    current = next;
                    next = 0;
                }
            }
            return ans.ToArray();
        }
    }
}
