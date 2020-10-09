using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using System.Linq;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T104__MaximumDepthofBinaryTreeTests
    {
        [TestMethod()]
        public void MaxDepthTest()
        {
            var input = new int?[] { 3, 9, 20, null, null, 15, 7 };
			var root = GetTree(input);

			T104__MaximumDepthofBinaryTree t104__MaximumDepthof = new T104__MaximumDepthofBinaryTree();
			var depth = t104__MaximumDepthof.MaxDepth2(root);
			Assert.AreEqual(3, depth);
        }

		public static int?[] TreeNode2Arr(TreeNode root)
        {
			List<int?> vals = new List<int?>();

			Queue<TreeNode> trees = new Queue<TreeNode>();
			trees.Enqueue(root);
			while (trees.Count > 0)
            {
				
				TreeNode node = trees.Dequeue();
                if (node == null)
                {
					vals.Add(null);
					continue;
                }
				vals.Add(node.val);
				trees.Enqueue(node.left);
				trees.Enqueue(node.right);
            }
			var count = vals.FindLastIndex(v => v != null) + 1;
			return vals.Take(count).ToArray();
        }

        public static TreeNode GetTree(int?[] arr)
        {
            if (arr == null || arr.Length == 0 || arr[0] == null)
                return null;

			TreeNode root = CreateNode(arr[0]);
			Queue<TreeNode> queue = new Queue<TreeNode>();
			queue.Enqueue(root);
			int index = 1;
			while (queue.Count > 0)
			{
				TreeNode node = queue.Dequeue();
				if (node == null) 
					continue;
				if (index < arr.Length)
				{
					node.left = CreateNode(arr[index++]);
					queue.Enqueue(node.left);
				}
				if (index < arr.Length)
				{
					node.right = CreateNode(arr[index++]);
					queue.Enqueue(node.right);
				}
			}
			return root;
		}

		public static TreeNode CreateNode(int? val)
		{
			if (val == null) 
				return null;
			return new TreeNode((int)val);
		}
	}
}