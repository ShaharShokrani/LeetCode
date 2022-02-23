using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/majority-element/
    /// </summary>
    [TestClass]
    public class MajorityElementClass
    {
        [TestMethod, Timeout(2000)]
        public void MajorityElementTest()
        {
            Assert.AreEqual(4, MajorityElement(new int[3] { 4, 5, 4 }));
            Assert.AreEqual(3, MajorityElement(new int[3] { 3, 2, 3 }));
            Assert.AreEqual(2, MajorityElement(new int[7] { 2, 2, 1, 1, 1, 2, 2 }));
        }

        IDictionary<int, int> candidates = new Dictionary<int, int>();
        public int MajorityElement(int[] nums)
        {           
            int result = 0;
            int compare = nums.Length / 2;
            foreach (int num in nums)
            {
                if (candidates.ContainsKey(num))
                {
                    candidates[num]++;
                }
                else
                {
                    candidates.Add(num, 1);
                }

                if (candidates[num] > (compare))
                {
                    return num;                    
                }
            }

            return result;
        }
    }
}