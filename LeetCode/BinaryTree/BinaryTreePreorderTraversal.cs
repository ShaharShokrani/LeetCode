using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.BinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-preorder-traversal/
    /// </summary>
    [TestClass]
    public class BinaryTreePreorderTraversal
    {
        [TestMethod]
        public void PreorderTraversalTest()
        {
            TreeNode tree = new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                }
            };
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, PreorderTraversal(tree).ToList());
        }

        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();

            Visit(root, result);

            return result;
        }

        private void Visit(TreeNode root, List<int> result)
        {
            if (root == null)
                return;

            result.Add(root.val);

            Visit(root.left, result);

            Visit(root.right, result);
        }
    }
}