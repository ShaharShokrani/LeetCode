using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays.Arrays
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    [TestClass]
    public class TwoSumClass
    {
        [TestMethod, Timeout(2000)]
        public void TwoSumTest()
        {
            CollectionAssert.AreEquivalent(new int[] { 0, 1 }, TwoSum(new int[] { 2, 7, 11, 15 }, 9));
            CollectionAssert.AreEquivalent(new int[] { 1, 2 }, TwoSum(new int[] { 3, 2, 4 }, 6));
            CollectionAssert.AreEquivalent(new int[] { 0, 1 }, TwoSum(new int[] { 3, 3 }, 6));
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            IDictionary<int, int> keyValues = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                int lookup = target - num;
                    
                if (keyValues.ContainsKey(lookup))
                {
                    result[0] = keyValues[lookup];
                    result[1] = i;

                    return result;
                }

                if (!keyValues.ContainsKey(num))
                {
                    keyValues[num] = i;
                }
            }

            return result;
        }
    }
}