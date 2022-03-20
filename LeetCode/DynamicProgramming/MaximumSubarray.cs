using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/
    /// </summary>
    [TestClass]
    public class MaximumSubarray
    {
        [TestMethod]
        public void MaxSubArrayTest1()
        {
            Assert.AreEqual(6, MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }

        [TestMethod]
        public void MaxSubArrayTest2()
        {
            Assert.AreEqual(1000000003, MaxSubArray(new[] { -2, 1000000000, -3, 4, -1, 2, 1, -5, 4 }));
        }        

        [TestMethod]
        public void MaxSubArrayTest3()
        {
            Assert.AreEqual(23, MaxSubArray(new[] { 5, 4, -1, 7, 8 }));
        }

        [TestMethod]
        public void MaxSubArrayTest4()
        {
            Assert.AreEqual(1, MaxSubArray(new[] { 1 }));
        }

        [TestMethod]
        public void MaxSubArrayTest5()
        {
            Assert.AreEqual(3, MaxSubArray(new[] { 1, 2 }));
        }

        [TestMethod]
        public void MaxSubArrayTest6()
        {
            Assert.AreEqual(-1, MaxSubArray(new[] { -1 }));
        }

        public int MaxSubArray(int[] nums)
        {
            int currentSubarray = nums[0];
            int maxSubarray = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int num = nums[i];
                currentSubarray = Math.Max(num, currentSubarray + num);
                maxSubarray = Math.Max(maxSubarray, currentSubarray);
            }

            return maxSubarray;
        }

    }
}
