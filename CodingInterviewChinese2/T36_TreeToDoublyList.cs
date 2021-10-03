using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T36_TreeToDoublyList
    {
        public TreeNode TreeToDoublyList(TreeNode root)
        {
            if (root == null)
                return null;

            TreeNode tail = TreeConvert(root);
            TreeNode head = tail;
            while (head.left != null)
                head = head.left;
            head.left = tail;
            tail.right = head;
            return head;
        }

        TreeNode TreeConvert(TreeNode root)
        {
            if (root == null)
                return null;

            var pCurrent = root;
            var temp = TreeConvert(pCurrent.left);
            if (temp != null)
            {
                //while (temp.right != null)
                //    temp = temp.right;

                temp.right = pCurrent;
                pCurrent.left = temp;
            }


            temp = TreeConvert(pCurrent.right);
            if(temp != null)
            {
                while (temp.left != null)
                {
                    temp = temp.left;
                }
                temp.left = pCurrent;
                pCurrent.right = temp;
            }

            while (pCurrent.right != null)
                pCurrent = pCurrent.right;
            
            return pCurrent;
        }
    }
}
