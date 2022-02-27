using LeetCode.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.Arrays
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    [TestClass]
    public class RemoveDuplicatesFromSortedArray
    {
        [TestMethod]
        public void RemoveDuplicatesTest()
        {
            int[] nums = new int[3] { 1,1,2 }; // Input array
            int[] expectedNums = new int[2] { 1, 2 }; // The expected answer with correct length

            int k = RemoveDuplicates(nums); // Calls your implementation

            Assert.AreEqual(expectedNums.Length, k);
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(expectedNums[i], nums[i]);
            }
        }

        [TestMethod]
        public void RemoveDuplicatesTest2()
        {
            int[] nums = new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }; // Input array
            int[] expectedNums = new int[5] { 0, 1, 2, 3, 4 }; // The expected answer with correct length

            int k = RemoveDuplicates(nums); // Calls your implementation

            Assert.AreEqual(expectedNums.Length, k);
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(expectedNums[i], nums[i]);
            }
        }

        [TestMethod]
        public void RemoveDuplicatesTest3()
        {
            int[] nums = new int[4] { 1, 1, 2, 3 }; // Input array
            int[] expectedNums = new int[3] { 1, 2, 3 }; // The expected answer with correct length

            int k = RemoveDuplicates(nums); // Calls your implementation

            Assert.AreEqual(expectedNums.Length, k);
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(expectedNums[i], nums[i]);
            }
        }

        public int RemoveDuplicates(int[] nums)
        {
            int result = 0;

            for (int i = 1; i < nums.Length ; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    result++;
                    continue;
                }

                nums[i - result] = nums[i];
            }

            return nums.Length - result;
        }
    }
}