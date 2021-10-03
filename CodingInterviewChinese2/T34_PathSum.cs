using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T34_PathSum
    {
        IList<IList<int>> _ans = new List<IList<int>>();
        List<int> _path = new List<int>();
        public IList<IList<int>> PathSum(TreeNode root, int target)
        {
            if (root != null)
                GetPath(root, target);
            return _ans;
        }

        void GetPath(TreeNode root, int target)
        {
            target -= root.val;
            _path.Add(root.val);
            if (target == 0 && root.left == null && root.right == null)
            {
                _ans.Add(_path.ToArray());
                return;
            }
            if(root.left != null)
                GetPath(root.left, target);

            if(root.right != null)
                GetPath(root.right, target);
            _path.RemoveAt(_path.Count - 1);

        }
    }
}
