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
    /// https://leetcode.com/problems/single-number/
    /// </summary>
    [TestClass]
    public class SingleNumberTests
    {
        [TestMethod]
        public void SingleNumberTest1()
        {
            var actual = new int[] { 2, 2, 1 };            

            Assert.AreEqual(1, SingleNumber(actual)); // Calls your implementation
        }

        [TestMethod]
        public void SingleNumberTest2()
        {
            var actual = new int[] { 4, 1, 2, 1, 2 };

            Assert.AreEqual(4, SingleNumber(actual)); // Calls your implementation
        }
        //1,1,2,2,4

        [TestMethod]
        public void SingleNumberTest3()
        {
            var actual = new int[] { 1 };

            Assert.AreEqual(1, SingleNumber(actual)); // Calls your implementation
        }

        public int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            int result = nums[0];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i+1])
                {
                    i++;
                    result = nums[i + 1];
                }
                else
                {
                    return nums[i];
                }
            }

            return result;
        }
    }
}