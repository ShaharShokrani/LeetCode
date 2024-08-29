using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/climbing-stairs/
    /// </summary>
    [TestClass]
    public class ClimbingStairs
    {
        [TestMethod]
        public void ClimbStairsTest()
        {
            Assert.AreEqual(2, ClimbStairs(2));
            Assert.AreEqual(3, ClimbStairs(3));            
        }
        
        private IDictionary<int, int> memo = new Dictionary<int, int>();
        public int ClimbStairs(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else if (n == 2) return 2;

            // Check if the result is already computed
            if (memo.ContainsKey(n)) return memo[n];

            // Compute and store the result in the memo dictionary
            int result = ClimbStairs(n - 2) + ClimbStairs(n - 1);
            memo[n] = result;

            return result;
        }
    }
}
