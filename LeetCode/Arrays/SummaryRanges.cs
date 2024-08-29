using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays.Arrays
{
    /// <summary>
    /// https://leetcode.com/problems/summary-ranges/
    /// </summary>
    [TestClass]
    public class SummaryRangesClass
    {
        [TestMethod]
        public void SummaryRangesTest()
        {
            int[] nums = new int[] { 0, 1, 2, 4, 5, 7 }; // Input array            

            IList<string> actual = SummaryRanges(nums); // Calls your implementation

            IList<string> expected = new List<string>()
            {
                "0->2",
                "4->5",
                "7"
            };

            CollectionAssert.AreEqual(expected.ToList(), actual.ToList());
        }

        public IList<string> SummaryRanges(int[] nums)
        {
            IList<string> result = new List<string>();            
            if (nums.Length == 0)
                return result;
            
            int currentStartRangeIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1 ||
                    nums[i] != nums[i + 1] - 1)
                {
                    string range;
                    if (currentStartRangeIndex != i)
                    {
                        range = nums[currentStartRangeIndex] + "->" + nums[i];
                    }
                    else
                    {
                        range = nums[currentStartRangeIndex].ToString();
                    }
                    result.Add(range);

                    currentStartRangeIndex = i + 1;
                }
            }            

            return result;
        }
    }
}