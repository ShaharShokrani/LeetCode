using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace LeetCode.BinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/range-sum-of-bst/
    /// </summary>
    [TestClass]
    public class RangeSumOfBst
    {
        [TestMethod]
        public void RangeSumBSTTest()
        {
            TreeNode tree = new TreeNode(10)
            {                
                left = new TreeNode(5)
                {                    
                    left = new TreeNode(3),
                    right = new TreeNode(7)
                },
                right = new TreeNode(15)
                {
                    right = new TreeNode(18)
                }
            };
            Assert.AreEqual(32, RangeSumBST(tree, 7, 15));
        }

        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null)
                return 0;

            if (root.val >= low && root.val <= high)
                return root.val + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
            else
                return RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
        }
    }
}