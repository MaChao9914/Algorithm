using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T32_3_LevelOrder
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> ans = new List<List<int>>();
            List<int> currentLevel = new List<int>();
            int next = 0;
            int current = 0;
            bool left = true;

            Stack<TreeNode> tree1 = new Stack<TreeNode>();
            Stack<TreeNode> tree2 = new Stack<TreeNode>();

            if (root != null)
            {
                tree1.Push(root);
                current += 1;
            }

            while (tree1.Count != 0 || tree2.Count != 0)
            {
                if (left)
                {
                    var temp = tree1.Pop();
                    currentLevel.Add(temp.val);
                    current -= 1;

                    if (temp.left != null)
                    {
                        tree2.Push(temp.left);
                        next++;
                    }
                    if (temp.right != null)
                    {
                        tree2.Push(temp.right);
                        next++;
                    }
                }
                else
                {
                    var temp = tree2.Pop();
                    currentLevel.Add(temp.val);
                    current -= 1;

                    if (temp.right != null)
                    {
                        tree1.Push(temp.right);
                        next++;
                    }
                    if (temp.left != null)
                    {
                        tree1.Push(temp.left);
                        next++;
                    }
                }

                if (current == 0)
                {
                    ans.Add(currentLevel);
                    currentLevel = new List<int>();
                    current = next;
                    next = 0;

                    if (left)
                        left = false;
                    else
                        left = true;
                }
            }
            return ans.ToArray();
        }
    }
}
